using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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


        #region [DLL]

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

        [DllImport("user32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);


        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                                        int size, string filePath);

        public delegate bool EnumDelegate(IntPtr hWnd, int lParam);

        #endregion [DLL]



        #region [VAR]
        class wndList
        {
            public IntPtr hWnd;
            public string className;
        }
        List<wndList> collection = new List<wndList>();

        List<int> list_keys = new List<int>();

        string CON_DATFILE_DIR = Environment.CurrentDirectory + @"\DAT\";

        int m_count_1;
        int m_count_2;
        int m_count_3;
        int m_count_4;
        int m_count_5;
        int m_count_rbutton;
        int m_count_space;
        #endregion [VAR]


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
            GetDatFileList();
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
            GetDatFileList();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (ckb_1.Checked && cbo_key_1.SelectedIndex >= 0 && num_1.Value > 0)
            {
                m_count_1 = int.Parse(num_1.Value.ToString());
                timer1.Interval = int.Parse(num_1.Value.ToString()) * 1000;
                timer1.Enabled = true;
            }
            if (ckb_2.Checked && cbo_key_2.SelectedIndex >= 0 && num_2.Value > 0)
            {
                m_count_2 = int.Parse(num_2.Value.ToString());
                timer2.Interval = int.Parse(num_2.Value.ToString()) * 1000;
                timer2.Enabled = true;
            }
            if (ckb_3.Checked && cbo_key_3.SelectedIndex >= 0 && num_3.Value > 0)
            {
                m_count_3 = int.Parse(num_3.Value.ToString());
                timer3.Interval = int.Parse(num_3.Value.ToString()) * 1000;
                timer3.Enabled = true;
            }
            if (ckb_4.Checked && cbo_key_4.SelectedIndex >= 0 && num_4.Value > 0)
            {
                m_count_4 = int.Parse(num_4.Value.ToString());
                timer4.Interval = int.Parse(num_4.Value.ToString()) * 1000;
                timer4.Enabled = true;
            }
            if (ckb_5.Checked && cbo_key_5.SelectedIndex >= 0 && num_5.Value > 0)
            {
                m_count_5 = int.Parse(num_5.Value.ToString());
                timer5.Interval = int.Parse(num_5.Value.ToString()) * 1000;
                timer5.Enabled = true;
            }

            if (ckb_rbutton.Checked && num_rbutton.Value > 0)
            {
                m_count_rbutton = int.Parse(num_rbutton.Value.ToString());
                timer_rbutton.Interval = int.Parse(num_rbutton.Value.ToString()) * 1000;
                timer_rbutton.Enabled = true;
            }
            if (ckb_space.Checked && num_space.Value > 0)
            {
                m_count_space = int.Parse(num_space.Value.ToString());
                timer_space.Interval = int.Parse(num_space.Value.ToString()) * 1000;
                timer_space.Enabled = true;
            }

            timer_main.Enabled = true;

            if (string.IsNullOrEmpty(tb_datname.Text) == false)
            {
                SaveDatFile(tb_datname.Text);
            }


            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            btn_stop.Enabled = true;

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

            timer_main.Enabled = false;

            foreach (Control c in this.Controls)
            {
                c.Enabled = true;
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            // 윈도우가 최소화 되어 있다면 활성화 시킨다
            ShowWindowAsync(GetHandle(), Constants.SW_SHOWNORMAL);

            // 윈도우에 포커스를 줘서 최상위로 만든다
            SetForegroundWindow(GetHandle());
        }

        private void cbo_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_handleno.Text = GetHandle().ToString();
            lb_classname.Text = GetWindowName();
        }


        #region [DAT FILE]        

        private void LoadDatFile(string filename)
        {
            if (!Directory.Exists(CON_DATFILE_DIR))
            {
                Directory.CreateDirectory(CON_DATFILE_DIR);
            }

            tb_datname.Text = filename;

            string sFilename = filename + ".dat";
            string sFilepath = CON_DATFILE_DIR + sFilename;

            StringBuilder sCKB = new StringBuilder();
            StringBuilder sCBO = new StringBuilder();
            StringBuilder sNUM = new StringBuilder();

            GetPrivateProfileString("FUNC_1", "ckb_1", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_1", "cbo_key_1", "-1", sCBO, 255, sFilepath);
            GetPrivateProfileString("FUNC_1", "num_1", "1", sNUM, 255, sFilepath);
            ckb_1.Checked = bool.Parse(sCKB.ToString());
            cbo_key_1.SelectedIndex = int.Parse(sCBO.ToString());
            num_1.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_2", "ckb_2", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_2", "cbo_key_2", "-1", sCBO, 255, sFilepath);
            GetPrivateProfileString("FUNC_2", "num_2", "1", sNUM, 255, sFilepath);
            ckb_2.Checked = bool.Parse(sCKB.ToString());
            cbo_key_2.SelectedIndex = int.Parse(sCBO.ToString());
            num_2.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_3", "ckb_3", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_3", "cbo_key_3", "-1", sCBO, 255, sFilepath);
            GetPrivateProfileString("FUNC_3", "num_3", "1", sNUM, 255, sFilepath);
            ckb_3.Checked = bool.Parse(sCKB.ToString());
            cbo_key_3.SelectedIndex = int.Parse(sCBO.ToString());
            num_3.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_4", "ckb_4", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_4", "cbo_key_4", "-1", sCBO, 255, sFilepath);
            GetPrivateProfileString("FUNC_4", "num_4", "1", sNUM, 255, sFilepath);
            ckb_4.Checked = bool.Parse(sCKB.ToString());
            cbo_key_4.SelectedIndex = int.Parse(sCBO.ToString());
            num_4.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_5", "ckb_5", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_5", "cbo_key_5", "-1", sCBO, 255, sFilepath);
            GetPrivateProfileString("FUNC_5", "num_5", "1", sNUM, 255, sFilepath);
            ckb_5.Checked = bool.Parse(sCKB.ToString());
            cbo_key_5.SelectedIndex = int.Parse(sCBO.ToString());
            num_5.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_RBUTTON", "ckb_rbutton", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_RBUTTON", "num_rbutton", "1", sNUM, 255, sFilepath);
            ckb_rbutton.Checked = bool.Parse(sCKB.ToString());
            num_rbutton.Value = int.Parse(sNUM.ToString());

            GetPrivateProfileString("FUNC_SPACE", "ckb_space", "False", sCKB, 255, sFilepath);
            GetPrivateProfileString("FUNC_SPACE", "num_space", "1", sNUM, 255, sFilepath);
            ckb_space.Checked = bool.Parse(sCKB.ToString());
            num_space.Value = int.Parse(sNUM.ToString());
        }

        private void SaveDatFile(string sName)
        {
            if (!Directory.Exists(CON_DATFILE_DIR))
            {
                Directory.CreateDirectory(CON_DATFILE_DIR);
            }

            string sFilename = sName + ".dat";
            string sFilepath = CON_DATFILE_DIR + sFilename;

            WritePrivateProfileString("FUNC_1", "ckb_1", ckb_1.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_1", "cbo_key_1", cbo_key_1.SelectedIndex.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_1", "num_1", num_1.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_2", "ckb_2", ckb_2.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_2", "cbo_key_2", cbo_key_2.SelectedIndex.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_2", "num_2", num_2.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_3", "ckb_3", ckb_3.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_3", "cbo_key_3", cbo_key_3.SelectedIndex.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_3", "num_3", num_3.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_4", "ckb_4", ckb_4.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_4", "cbo_key_4", cbo_key_4.SelectedIndex.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_4", "num_4", num_4.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_5", "ckb_5", ckb_5.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_5", "cbo_key_5", cbo_key_5.SelectedIndex.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_5", "num_5", num_5.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_RBUTTON", "ckb_rbutton", ckb_rbutton.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_RBUTTON", "num_rbutton", num_rbutton.Value.ToString(), sFilepath);

            WritePrivateProfileString("FUNC_SPACE", "ckb_space", ckb_space.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC_SPACE", "num_space", num_space.Value.ToString(), sFilepath);
        }

        private void GetDatFileList()
        {
            if (!Directory.Exists(CON_DATFILE_DIR))
            {
                Directory.CreateDirectory(CON_DATFILE_DIR);
            }

            cbo_datlist.Items.Clear();

            DirectoryInfo di = new DirectoryInfo(CON_DATFILE_DIR);
            foreach (var item in di.GetFiles())
            {
                string sName = item.Name.Split('.')[0];
                cbo_datlist.Items.Add(sName);
            }
        }

        private void cbo_datlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sFilename = cbo_datlist.SelectedItem.ToString();
            LoadDatFile(sFilename);
        }
        #endregion [DAT FILE]



        #region [TIMER]
        private void timer_main_Tick(object sender, EventArgs e)
        {
            if (m_count_1 > 0 && ckb_1.Checked)
            {
                m_count_1--;
                lb_1.Text = m_count_1.ToString();
                if (m_count_1 == 0)
                {
                    m_count_1 = int.Parse(num_1.Value.ToString());
                }
            }

            if (m_count_2 > 0 && ckb_2.Checked)
            {
                m_count_2--;
                lb_2.Text = m_count_2.ToString();
                if (m_count_2 == 0)
                {
                    m_count_2 = int.Parse(num_2.Value.ToString());
                }
            }

            if (m_count_3 > 0 && ckb_3.Checked)
            {
                m_count_3--;
                lb_3.Text = m_count_3.ToString();
                if (m_count_3 == 0)
                {
                    m_count_3 = int.Parse(num_3.Value.ToString());
                }
            }

            if (m_count_4 > 0 && ckb_4.Checked)
            {
                m_count_4--;
                lb_4.Text = m_count_4.ToString();
                if (m_count_4 == 0)
                {
                    m_count_4 = int.Parse(num_4.Value.ToString());
                }
            }

            if (m_count_5 > 0 && ckb_5.Checked)
            {
                m_count_5--;
                lb_5.Text = m_count_5.ToString();
                if (m_count_5 == 0)
                {
                    m_count_5 = int.Parse(num_5.Value.ToString());
                }
            }

            if (m_count_rbutton > 0 && ckb_rbutton.Checked)
            {
                m_count_rbutton--;
                lb_rbutton.Text = m_count_rbutton.ToString();
                if (m_count_rbutton == 0)
                {
                    m_count_rbutton = int.Parse(num_rbutton.Value.ToString());
                }
            }

            if (m_count_space > 0 && ckb_space.Checked)
            {
                m_count_space--;
                lb_space.Text = m_count_space.ToString();
                if (m_count_space == 0)
                {
                    m_count_space = int.Parse(num_space.Value.ToString());
                }
            }
        }

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
