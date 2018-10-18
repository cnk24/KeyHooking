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

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern int PostMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);


        class wndList
        {
            public IntPtr hWnd;
            public string className;
        }
        List<wndList> collection = new List<wndList>();

        List<int> list_keys = new List<int>();


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_keys.Add(Constants.VK_F1);
            list_keys.Add(Constants.VK_F2);
            list_keys.Add(Constants.VK_F3);
            list_keys.Add(Constants.VK_F4);
            list_keys.Add(Constants.VK_F5);
            list_keys.Add(Constants.VK_F6);
            list_keys.Add(Constants.VK_F7);
            list_keys.Add(Constants.VK_F8);
            list_keys.Add(Constants.VK_F9);
            list_keys.Add(Constants.VK_F10);
            list_keys.Add(Constants.VK_F11);
            list_keys.Add(Constants.VK_F12);

            GetWindows();
        }

        private void GetWindows()
        {
            cbo_list.Items.Clear();
            lb_handleno.Text = "";
            lb_classname.Text = "";

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
                    cbo_list.Items.Add(item.className);
                }
            }
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

        private IntPtr GetHandle()
        {
            return collection[cbo_list.SelectedIndex].hWnd;
        }

        private string GetWindowName()
        {
            return collection[cbo_list.SelectedIndex].className;
        }

        private void SendKey(IntPtr hWnd, int key)
        {
            PostMessage(hWnd, Constants.WM_KEYDOWN, key, 0);
            PostMessage(hWnd, Constants.WM_KEYUP, key, 0);
        }

        private void SendLbutton(IntPtr hWnd)
        {
            PostMessage(hWnd, Constants.WM_LBUTTONDOWN, 0, 0);
            PostMessage(hWnd, Constants.WM_LBUTTONUP, 0, 0);
        }

        private void SendRbutton(IntPtr hWnd)
        {
            PostMessage(hWnd, Constants.WM_RBUTTONDOWN, 0, 0);
            PostMessage(hWnd, Constants.WM_RBUTTONUP, 0, 0);
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetWindows();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (ckb_1.Checked && cbo_key_1.SelectedIndex >= 0 && num_1.Value > 0)
            {
                timer1.Interval = int.Parse(num_1.Value.ToString()) * 1000;
                timer1.Enabled = true;
            }
            if (ckb_2.Checked && cbo_key_2.SelectedIndex >= 0 && num_2.Value > 0)
            {
                timer2.Interval = int.Parse(num_2.Value.ToString()) * 1000;
                timer2.Enabled = true;
            }
            if (ckb_3.Checked && cbo_key_3.SelectedIndex >= 0 && num_3.Value > 0)
            {
                timer3.Interval = int.Parse(num_3.Value.ToString()) * 1000;
                timer3.Enabled = true;
            }
            if (ckb_4.Checked && cbo_key_4.SelectedIndex >= 0 && num_4.Value > 0)
            {
                timer4.Interval = int.Parse(num_4.Value.ToString()) * 1000;
                timer4.Enabled = true;
            }
            if (ckb_5.Checked && cbo_key_5.SelectedIndex >= 0 && num_5.Value > 0)
            {
                timer5.Interval = int.Parse(num_5.Value.ToString()) * 1000;
                timer5.Enabled = true;
            }

            if (ckb_rbutton.Checked && num_rbutton.Value > 0)
            {
                timer_rbutton.Interval = int.Parse(num_rbutton.Value.ToString()) * 1000;
                timer_rbutton.Enabled = true;
            }
            if (ckb_space.Checked && num_space.Value > 0)
            {
                timer_space.Interval = int.Parse(num_space.Value.ToString()) * 1000;
                timer_space.Enabled = true;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;
            timer5.Enabled = false;

            timer_rbutton.Enabled = false;
            timer_space.Enabled = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            SetForegroundWindow(GetHandle());
        }

        private void cbo_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_handleno.Text = GetHandle().ToString();
            lb_classname.Text = GetWindowName();
        }


        #region [TIMER]
        private void timer1_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), list_keys[cbo_key_1.SelectedIndex]);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), list_keys[cbo_key_2.SelectedIndex]);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), list_keys[cbo_key_3.SelectedIndex]);
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), list_keys[cbo_key_4.SelectedIndex]);
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), list_keys[cbo_key_5.SelectedIndex]);
        }

        private void timer_rbutton_Tick(object sender, EventArgs e)
        {
            SendRbutton(GetHandle());
        }

        private void timer_space_Tick(object sender, EventArgs e)
        {
            SendKey(GetHandle(), Constants.VK_SPACE);
        }

        #endregion [TIMER]


    }
}
