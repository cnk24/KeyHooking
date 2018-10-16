using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoseOnline
{
    public partial class frmMain : Form
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int X;
            public int Y;

            public POINT(int x, int y)
            {
                this.X = x;
                this.Y = y;
            }

            public POINT(System.Drawing.Point pt) : this(pt.X, pt.Y) { }

            public static implicit operator System.Drawing.Point(POINT p)
            {
                return new System.Drawing.Point(p.X, p.Y);
            }

            public static implicit operator POINT(System.Drawing.Point p)
            {
                return new POINT(p.X, p.Y);
            }
        }

        [DllImport("user32.dll")]
        public static extern IntPtr WindowFromPoint(POINT p);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetCursorPos(ref POINT p);

        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern long GetWindowText(IntPtr hwnd, StringBuilder lpString, long cch);

        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(IntPtr hwnd);

        [DllImport("user32.dll")]
        public static extern IntPtr ChildWindowFromPoint(IntPtr hWndParent, POINT p);

        [DllImport("user32.dll")]
        public static extern long GetClassName(IntPtr hwnd, StringBuilder lpClassName, long nMaxCount);
        //public static extern int GetClassName(int hwnd, StringBuilder lpClassName, int nMaxCount);

        [DllImport("user32.dll")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        public static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDelegate lpEnumCallbackFunction, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern bool IsWindowVisible(IntPtr hWnd);

        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);


        class wndList
        {
            public IntPtr hWnd;
            public string className;
        }

        POINT p;


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var collection = new List<wndList>();
            EnumDelegate filter = delegate (IntPtr hWnd, int lParam)
            {
                StringBuilder strbTitle = new StringBuilder(255);
                GetWindowText(hWnd, strbTitle, strbTitle.Capacity + 1);
                string strTitle = strbTitle.ToString();

                if (IsWindowVisible(hWnd) && string.IsNullOrEmpty(strTitle) == false)
                {
                    wndList wnd = new wndList();
                    wnd.hWnd = hWnd;
                    wnd.className = strTitle;
                    collection.Add(wnd);
                }
                return true;
            };

            if (EnumDesktopWindows(IntPtr.Zero, filter, IntPtr.Zero))
            {
                foreach (var item in collection)
                {
                    cbList.Items.Add(item.className);
                }
            }



            /*
            bool retVal = GetCursorPos(ref p);
            if (retVal)
            {
                //lblXPos.Text = "Mouse X : " + Convert.ToString(p.X);
                //lblYPos.Text = "Mouse Y : " + Convert.ToString(p.Y);
                IntPtr hWnd = WindowFromPoint(p);
                //lblHWnd.Text = "Window Handle : " + hwnd.ToInt64();
                if (hWnd != IntPtr.Zero)
                {

                    //int length = GetWindowTextLength(hWnd);
                    //StringBuilder sb = new StringBuilder(length + 1);
                    //GetWindowText(hWnd, sb, sb.Capacity);


                    //StringBuilder sbWinText = new StringBuilder(255);
                    //GetWindowText(hWnd, sbWinText, 255);



                    //rtbCaption.Text = GetCaptionOfWindow(hwnd);
                    //rtbClassName.Text = GetClassNameOfWindow(hwnd);
                    string a = GetCaptionOfWindow(hWnd);
                    string b = GetClassNameOfWindow(hWnd);

                    //For Parent 
                    //IntPtr hWndParent = GetParent(hwnd);
                    //if (hWndParent.ToInt64() > 0)
                    {
                        //rtbWinParent.Text = GetCaptionOfWindow(hWndParent);
                    }
                }
            }
            */


        }

        private string GetCaptionOfWindow(IntPtr hwnd)
        {
            string caption = "";
            StringBuilder windowText = null;
            try
            {
                int max_length = GetWindowTextLength(hwnd);
                windowText = new StringBuilder("", max_length + 5);
                GetWindowText(hwnd, windowText, max_length + 2);

                if (!String.IsNullOrEmpty(windowText.ToString()) && !String.IsNullOrWhiteSpace(windowText.ToString()))
                    caption = windowText.ToString();
            }
            catch (Exception ex)
            {
                caption = ex.Message;
            }
            finally
            {
                windowText = null;
            }
            return caption;
        }

        private string GetClassNameOfWindow(IntPtr hwnd)
        {
            string className = "";
            StringBuilder classText = null;
            try
            {
                int cls_max_length = 1000;
                classText = new StringBuilder("", cls_max_length + 5);
                GetClassName(hwnd, classText, cls_max_length + 2);

                if (!String.IsNullOrEmpty(classText.ToString()) && !String.IsNullOrWhiteSpace(classText.ToString()))
                    className = classText.ToString();
            }
            catch (Exception ex)
            {
                className = ex.Message;
            }
            finally
            {
                classText = null;
            }
            return className;
        }
        


    }
}
