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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoseOnline
{
    public partial class frmMain : Form
    {

        #region [DLL]        

        [DllImport("user32.dll")]
        public static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern long GetWindowText(IntPtr hwnd, StringBuilder lpString, long cch);

        [DllImport("user32.dll")]
        public static extern IntPtr GetParent(IntPtr hwnd);
        
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

        class tClass
        {
            public bool bCheck;
            public int nKey;
            public int nSec;
            public int nIng;
        }

        class wndList
        {
            public IntPtr hWnd;
            public string className;
        }
        List<wndList> collection = new List<wndList>();

        string CON_DATFILE_DIR = Environment.CurrentDirectory + @"\DAT\";

        int m_nGroupSec, m_nGroupIng, m_nGroupIndex;
        List<tClass> m_OnlyList = new List<tClass>();
        List<tClass> m_GroupList = new List<tClass>();

        #endregion [VAR]


        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetWindows();
            GetDatFileList();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void UIEnable(bool en)
        {
            foreach (Control con in this.Controls)
            {
                con.Enabled = en;
            }

            btn_stop.Enabled = true;
        }

        private int GetKey(string sKey)
        {
            int nKey = -1;

            switch (sKey)
            {
                case "F1":
                    nKey = Constants.VK_F1;
                    break;
                case "F2":
                    nKey = Constants.VK_F2;
                    break;
                case "F3":
                    nKey = Constants.VK_F3;
                    break;
                case "F4":
                    nKey = Constants.VK_F4;
                    break;
                case "F5":
                    nKey = Constants.VK_F5;
                    break;
                case "F6":
                    nKey = Constants.VK_F6;
                    break;
                case "F7":
                    nKey = Constants.VK_F7;
                    break;
                case "F8":
                    nKey = Constants.VK_F8;
                    break;
                case "F9":
                    nKey = Constants.VK_F9;
                    break;
                case "F10":
                    nKey = Constants.VK_F10;
                    break;
                case "F11":
                    nKey = Constants.VK_F11;
                    break;
                case "F12":
                    nKey = Constants.VK_F12;
                    break;
            }

            return nKey;
        }

        private void GetWindows()
        {
            cbo_list.Items.Clear();
            collection.Clear();
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

                    if (strTitle.Contains("RoseOnline"))
                    {
                        collection.Add(wnd);
                    }                    
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
            if (string.IsNullOrEmpty(tb_datname.Text) == false)
            {
                SaveDatFile(tb_datname.Text);
            }

<<<<<<< HEAD

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            btn_stop.Enabled = true;

=======
            SetOnlyList();
            SetGroupList();

            timer1.Enabled = true;
            UIEnable(false);
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
<<<<<<< HEAD
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
=======
            UIEnable(true);
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
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
<<<<<<< HEAD
            if (!Directory.Exists(CON_DATFILE_DIR))
            {
                Directory.CreateDirectory(CON_DATFILE_DIR);
            }
=======
            if (string.IsNullOrEmpty(filename)) return;
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069

            tb_datname.Text = filename;

            string sFilename = filename + ".dat";
            string sFilepath = CON_DATFILE_DIR + sFilename;

            StringBuilder sb = new StringBuilder();

            GetPrivateProfileString("FUNC", "only_check", "False", sb, 255, sFilepath);
            ckb_only.Checked = bool.Parse(sb.ToString());
            GetPrivateProfileString("FUNC", "group_check", "False", sb, 255, sFilepath);
            ckb_group.Checked = bool.Parse(sb.ToString());
            GetPrivateProfileString("FUNC", "group_sec", "1", sb, 255, sFilepath);
            tb_group_sec.Text = sb.ToString();


            int nOnlyCount = 0;
            int nGroupCount = 0;
            GetPrivateProfileString("DATA_COUNT", "only_count", "0", sb, 255, sFilepath);
            nOnlyCount = int.Parse(sb.ToString());
            GetPrivateProfileString("DATA_COUNT", "group_count", "0", sb, 255, sFilepath);
            nGroupCount = int.Parse(sb.ToString());


            bool bCheck;
            string sKey;
            int nSec;

            for (int i=0; i<nOnlyCount; i++)
            {
                GetPrivateProfileString("DATAS", "only_check_" + i.ToString(), "False", sb, 255, sFilepath);
                bCheck = bool.Parse(sb.ToString());
                GetPrivateProfileString("DATAS", "only_key_" + i.ToString(), "", sb, 255, sFilepath);
                sKey = sb.ToString();
                GetPrivateProfileString("DATAS", "only_sec_" + i.ToString(), "1", sb, 255, sFilepath);
                nSec = int.Parse(sb.ToString());

                dgv_only.Rows.Add(bCheck, sKey, nSec, "0");
            }

            for (int i = 0; i < nGroupCount; i++)
            {
                GetPrivateProfileString("DATAS", "group_check_" + i.ToString(), "False", sb, 255, sFilepath);
                bCheck = bool.Parse(sb.ToString());
                GetPrivateProfileString("DATAS", "group_key_" + i.ToString(), "", sb, 255, sFilepath);
                sKey = sb.ToString();
                GetPrivateProfileString("DATAS", "group_sec_" + i.ToString(), "1", sb, 255, sFilepath);
                nSec = int.Parse(sb.ToString());

                dgv_group.Rows.Add(bCheck, sKey, nSec, "0");
            }
        }

        private void SaveDatFile(string sName)
        {
            if (string.IsNullOrEmpty(sName)) return;

            if (!Directory.Exists(CON_DATFILE_DIR))
            {
                Directory.CreateDirectory(CON_DATFILE_DIR);
            }

            string sFilename = sName + ".dat";
            string sFilepath = CON_DATFILE_DIR + sFilename;

            FileInfo fileDel = new FileInfo(sFilepath);
            if (fileDel.Exists)
            {
                fileDel.Delete();
            }

            WritePrivateProfileString("FUNC", "only_check", ckb_only.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC", "group_check", ckb_group.Checked.ToString(), sFilepath);
            WritePrivateProfileString("FUNC", "group_sec", tb_group_sec.Text, sFilepath);

            WritePrivateProfileString("DATA_COUNT", "only_count", dgv_only.Rows.Count.ToString(), sFilepath);
            WritePrivateProfileString("DATA_COUNT", "group_count", dgv_group.Rows.Count.ToString(), sFilepath);

            int nIndex = 0;
            foreach (DataGridViewRow row in dgv_only.Rows)
            {
                WritePrivateProfileString("DATAS", "only_check_" + nIndex.ToString(), row.Cells["col_only_check"].Value.ToString(), sFilepath);
                WritePrivateProfileString("DATAS", "only_key_" + nIndex.ToString(), row.Cells["col_only_key"].Value.ToString(), sFilepath);
                WritePrivateProfileString("DATAS", "only_sec_" + nIndex.ToString(), row.Cells["col_only_sec"].Value.ToString(), sFilepath);

                nIndex++;
            }

            nIndex = 0;
            foreach (DataGridViewRow row in dgv_group.Rows)
            {
                WritePrivateProfileString("DATAS", "group_check_" + nIndex.ToString(), row.Cells["col_group_check"].Value.ToString(), sFilepath);
                WritePrivateProfileString("DATAS", "group_key_" + nIndex.ToString(), row.Cells["col_group_key"].Value.ToString(), sFilepath);
                WritePrivateProfileString("DATAS", "group_sec_" + nIndex.ToString(), row.Cells["col_group_sec"].Value.ToString(), sFilepath);

                nIndex++;
            }
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




        #region [개별 콘드롤]

        private void btn_only_add_Click(object sender, EventArgs e)
        {
            if (cbo_only_keys.SelectedIndex < 0) return;

            string sKey = cbo_only_keys.SelectedItem.ToString();

            dgv_only.Rows.Add(true, sKey, "1", "0");
        }

        private void btn_only_clear_Click(object sender, EventArgs e)
        {
            dgv_only.Rows.Clear();
        }

        private void dgv_only_CellClick(object sender, DataGridViewCellEventArgs e)
        {
<<<<<<< HEAD
            if (m_count_1 > 0 && ckb_1.Checked)
=======
            DataGridView dgv = sender as DataGridView;
            int nRowIndex = e.RowIndex;
            int nColIndex = e.ColumnIndex;

            if (dgv.Columns["col_only_del"].Index == nColIndex)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                dgv.Rows.RemoveAt(nRowIndex);
            }
        }        

<<<<<<< HEAD
            if (m_count_2 > 0 && ckb_2.Checked)
=======
        private void SetOnlyList()
        {
            m_OnlyList.Clear();

            foreach (DataGridViewRow row in dgv_only.Rows)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                tClass tc = new tClass();
                tc.bCheck = Convert.ToBoolean(row.Cells["col_only_check"].Value);
                tc.nKey = GetKey(row.Cells["col_only_key"].Value.ToString());
                tc.nSec = Convert.ToInt32(row.Cells["col_only_sec"].Value.ToString());
                tc.nIng = tc.nSec;

                m_OnlyList.Add(tc);
            }
        }

        #endregion [개별 콘드롤]


<<<<<<< HEAD
            if (m_count_3 > 0 && ckb_3.Checked)
=======



        #region [그룹 콘드롤]

        private void btn_group_add_Click(object sender, EventArgs e)
        {
            if (cbo_group_keys.SelectedIndex < 0) return;

            string sKey = cbo_group_keys.SelectedItem.ToString();

            dgv_group.Rows.Add(true, sKey, "1", "0");

        }

        private void btn_group_clear_Click(object sender, EventArgs e)
        {
            dgv_group.Rows.Clear();
        }

        private void dgv_group_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            int nRowIndex = e.RowIndex;
            int nColIndex = e.ColumnIndex;

            if (dgv.Columns["col_group_del"].Index == nColIndex)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                dgv.Rows.RemoveAt(nRowIndex);
            }
        }

        private void SetGroupList()
        {
            m_nGroupIndex = 0;
            m_GroupList.Clear();

            m_nGroupSec = Convert.ToInt32(tb_group_sec.Text);
            m_nGroupIng = m_nGroupSec;

<<<<<<< HEAD
            if (m_count_4 > 0 && ckb_4.Checked)
=======
            foreach (DataGridViewRow row in dgv_group.Rows)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                tClass tc = new tClass();
                tc.bCheck = Convert.ToBoolean(row.Cells["col_group_check"].Value);
                tc.nKey = GetKey(row.Cells["col_group_key"].Value.ToString());
                tc.nSec = Convert.ToInt32(row.Cells["col_group_sec"].Value.ToString());
                tc.nIng = tc.nSec;

                m_GroupList.Add(tc);
            }
        }

        #endregion [그룹 콘드롤]




        #region [TIMER]

        private void OnlyProc()
        {
            int nRowIndex = 0;

<<<<<<< HEAD
            if (m_count_5 > 0 && ckb_5.Checked)
=======
            foreach (tClass tc in m_OnlyList)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                if (tc.bCheck)
                {
                    tc.nIng--;
                    dgv_only.Rows[nRowIndex].Cells["col_only_ing"].Value = tc.nIng.ToString();

                    if (tc.nIng == 0)
                    {
                        SendKey(GetHandle(), tc.nKey);
                        tc.nIng = tc.nSec;

                        Thread.Sleep(10);
                    }
                }

                nRowIndex++;
            }
        }

<<<<<<< HEAD
            if (m_count_rbutton > 0 && ckb_rbutton.Checked)
=======
        private void GroupProc()
        {
            if (m_nGroupIng > 0)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            {
                m_nGroupIng--;
                lb_group_ing.Text = m_nGroupIng.ToString();
            }            

            if (m_nGroupIng == 0)
            {
                tClass tc = m_GroupList[m_nGroupIndex];

                if (tc.bCheck == false)
                {
                    m_nGroupIndex++;
                    if (m_nGroupIndex >= dgv_group.Rows.Count)
                    {
                        m_nGroupIndex = 0;
                        m_nGroupIng = m_nGroupSec;
                        return;
                    }

                    tc = m_GroupList[m_nGroupIndex];
                }

<<<<<<< HEAD
            if (m_count_space > 0 && ckb_space.Checked)
            {
                m_count_space--;
                lb_space.Text = m_count_space.ToString();
                if (m_count_space == 0)
=======
                tc.nIng--;
                dgv_group.Rows[m_nGroupIndex].Cells["col_group_ing"].Value = tc.nIng.ToString();

                if (tc.nIng == 0)
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
                {
                    SendKey(GetHandle(), tc.nKey);
                    tc.nIng = tc.nSec;

                    m_nGroupIndex++;
                    if (m_nGroupIndex >= dgv_group.Rows.Count)
                    {
                        m_nGroupIndex = 0;
                        m_nGroupIng = m_nGroupSec;
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invoke(new MethodInvoker(delegate
            {
                if (ckb_only.Checked)
                {
                    OnlyProc();
                }                

                if (ckb_group.Checked)
                {
                    GroupProc();
                }
            }));
        }

        #endregion [TIMER]







    }
}
