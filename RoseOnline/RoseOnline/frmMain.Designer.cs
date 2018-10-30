namespace RoseOnline
{
    partial class frmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbo_list = new System.Windows.Forms.ComboBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_check = new System.Windows.Forms.Button();
            this.lb_handleno = new System.Windows.Forms.Label();
            this.lb_classname = new System.Windows.Forms.Label();
            this.btn_reload = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num_5 = new System.Windows.Forms.NumericUpDown();
            this.cbo_key_5 = new System.Windows.Forms.ComboBox();
            this.ckb_5 = new System.Windows.Forms.CheckBox();
            this.num_4 = new System.Windows.Forms.NumericUpDown();
            this.cbo_key_4 = new System.Windows.Forms.ComboBox();
            this.ckb_4 = new System.Windows.Forms.CheckBox();
            this.num_3 = new System.Windows.Forms.NumericUpDown();
            this.cbo_key_3 = new System.Windows.Forms.ComboBox();
            this.ckb_3 = new System.Windows.Forms.CheckBox();
            this.num_2 = new System.Windows.Forms.NumericUpDown();
            this.cbo_key_2 = new System.Windows.Forms.ComboBox();
            this.ckb_2 = new System.Windows.Forms.CheckBox();
            this.num_1 = new System.Windows.Forms.NumericUpDown();
            this.cbo_key_1 = new System.Windows.Forms.ComboBox();
            this.ckb_1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ckb_rbutton = new System.Windows.Forms.CheckBox();
            this.ckb_space = new System.Windows.Forms.CheckBox();
            this.num_rbutton = new System.Windows.Forms.NumericUpDown();
            this.num_space = new System.Windows.Forms.NumericUpDown();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.lb_4 = new System.Windows.Forms.Label();
            this.lb_5 = new System.Windows.Forms.Label();
            this.lb_rbutton = new System.Windows.Forms.Label();
            this.lb_space = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.timer_rbutton = new System.Windows.Forms.Timer(this.components);
            this.timer_space = new System.Windows.Forms.Timer(this.components);
            this.cbo_datlist = new System.Windows.Forms.ComboBox();
            this.tb_datname = new System.Windows.Forms.TextBox();
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_space)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_list
            // 
            this.cbo_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_list.FormattingEnabled = true;
            this.cbo_list.Location = new System.Drawing.Point(12, 12);
            this.cbo_list.Name = "cbo_list";
            this.cbo_list.Size = new System.Drawing.Size(195, 20);
            this.cbo_list.TabIndex = 0;
            this.cbo_list.SelectedIndexChanged += new System.EventHandler(this.cbo_list_SelectedIndexChanged);
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(252, 84);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(111, 102);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(252, 218);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(111, 102);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(294, 9);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(69, 59);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "창확인";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lb_handleno
            // 
            this.lb_handleno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_handleno.Location = new System.Drawing.Point(12, 45);
            this.lb_handleno.Name = "lb_handleno";
            this.lb_handleno.Size = new System.Drawing.Size(126, 23);
            this.lb_handleno.TabIndex = 4;
            this.lb_handleno.Text = "123456";
            this.lb_handleno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_classname
            // 
            this.lb_classname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_classname.Location = new System.Drawing.Point(144, 45);
            this.lb_classname.Name = "lb_classname";
            this.lb_classname.Size = new System.Drawing.Size(144, 23);
            this.lb_classname.TabIndex = 5;
            this.lb_classname.Text = "메모장";
            this.lb_classname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reload
            // 
            this.btn_reload.Location = new System.Drawing.Point(213, 9);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(75, 23);
            this.btn_reload.TabIndex = 6;
            this.btn_reload.Text = "갱신";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Controls.Add(this.num_5, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ckb_5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.num_4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_4, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ckb_4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.num_3, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb_3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.num_2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb_2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num_1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb_1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.ckb_rbutton, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.ckb_space, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.num_rbutton, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.num_space, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.lb_1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_3, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_4, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_5, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_rbutton, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_space, 3, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 245);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // num_5
            // 
            this.num_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_5.Location = new System.Drawing.Point(131, 138);
            this.num_5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(54, 21);
            this.num_5.TabIndex = 14;
            this.num_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbo_key_5
            // 
            this.cbo_key_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_key_5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key_5.FormattingEnabled = true;
            this.cbo_key_5.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbo_key_5.Location = new System.Drawing.Point(23, 138);
            this.cbo_key_5.Name = "cbo_key_5";
            this.cbo_key_5.Size = new System.Drawing.Size(102, 20);
            this.cbo_key_5.TabIndex = 9;
            // 
            // ckb_5
            // 
            this.ckb_5.AutoSize = true;
            this.ckb_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_5.Location = new System.Drawing.Point(3, 138);
            this.ckb_5.Name = "ckb_5";
            this.ckb_5.Size = new System.Drawing.Size(14, 21);
            this.ckb_5.TabIndex = 4;
            this.ckb_5.UseVisualStyleBackColor = true;
            // 
            // num_4
            // 
            this.num_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_4.Location = new System.Drawing.Point(131, 111);
            this.num_4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(54, 21);
            this.num_4.TabIndex = 13;
            this.num_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbo_key_4
            // 
            this.cbo_key_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_key_4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key_4.FormattingEnabled = true;
            this.cbo_key_4.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbo_key_4.Location = new System.Drawing.Point(23, 111);
            this.cbo_key_4.Name = "cbo_key_4";
            this.cbo_key_4.Size = new System.Drawing.Size(102, 20);
            this.cbo_key_4.TabIndex = 8;
            // 
            // ckb_4
            // 
            this.ckb_4.AutoSize = true;
            this.ckb_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_4.Location = new System.Drawing.Point(3, 111);
            this.ckb_4.Name = "ckb_4";
            this.ckb_4.Size = new System.Drawing.Size(14, 21);
            this.ckb_4.TabIndex = 3;
            this.ckb_4.UseVisualStyleBackColor = true;
            // 
            // num_3
            // 
            this.num_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_3.Location = new System.Drawing.Point(131, 84);
            this.num_3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(54, 21);
            this.num_3.TabIndex = 12;
            this.num_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbo_key_3
            // 
            this.cbo_key_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_key_3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key_3.FormattingEnabled = true;
            this.cbo_key_3.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbo_key_3.Location = new System.Drawing.Point(23, 84);
            this.cbo_key_3.Name = "cbo_key_3";
            this.cbo_key_3.Size = new System.Drawing.Size(102, 20);
            this.cbo_key_3.TabIndex = 7;
            // 
            // ckb_3
            // 
            this.ckb_3.AutoSize = true;
            this.ckb_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_3.Location = new System.Drawing.Point(3, 84);
            this.ckb_3.Name = "ckb_3";
            this.ckb_3.Size = new System.Drawing.Size(14, 21);
            this.ckb_3.TabIndex = 2;
            this.ckb_3.UseVisualStyleBackColor = true;
            // 
            // num_2
            // 
            this.num_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_2.Location = new System.Drawing.Point(131, 57);
            this.num_2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(54, 21);
            this.num_2.TabIndex = 11;
            this.num_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbo_key_2
            // 
            this.cbo_key_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_key_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key_2.FormattingEnabled = true;
            this.cbo_key_2.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbo_key_2.Location = new System.Drawing.Point(23, 57);
            this.cbo_key_2.Name = "cbo_key_2";
            this.cbo_key_2.Size = new System.Drawing.Size(102, 20);
            this.cbo_key_2.TabIndex = 6;
            // 
            // ckb_2
            // 
            this.ckb_2.AutoSize = true;
            this.ckb_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_2.Location = new System.Drawing.Point(3, 57);
            this.ckb_2.Name = "ckb_2";
            this.ckb_2.Size = new System.Drawing.Size(14, 21);
            this.ckb_2.TabIndex = 1;
            this.ckb_2.UseVisualStyleBackColor = true;
            // 
            // num_1
            // 
            this.num_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_1.Location = new System.Drawing.Point(131, 30);
            this.num_1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(54, 21);
            this.num_1.TabIndex = 10;
            this.num_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbo_key_1
            // 
            this.cbo_key_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_key_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_key_1.FormattingEnabled = true;
            this.cbo_key_1.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cbo_key_1.Location = new System.Drawing.Point(23, 30);
            this.cbo_key_1.Name = "cbo_key_1";
            this.cbo_key_1.Size = new System.Drawing.Size(102, 20);
            this.cbo_key_1.TabIndex = 5;
            // 
            // ckb_1
            // 
            this.ckb_1.AutoSize = true;
            this.ckb_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_1.Location = new System.Drawing.Point(3, 30);
            this.ckb_1.Name = "ckb_1";
            this.ckb_1.Size = new System.Drawing.Size(14, 21);
            this.ckb_1.TabIndex = 0;
            this.ckb_1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(23, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "스페이스 바";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(23, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 27);
            this.label2.TabIndex = 16;
            this.label2.Text = "오른쪽 버튼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ckb_rbutton
            // 
            this.ckb_rbutton.AutoSize = true;
            this.ckb_rbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_rbutton.Location = new System.Drawing.Point(3, 192);
            this.ckb_rbutton.Name = "ckb_rbutton";
            this.ckb_rbutton.Size = new System.Drawing.Size(14, 21);
            this.ckb_rbutton.TabIndex = 18;
            this.ckb_rbutton.UseVisualStyleBackColor = true;
            // 
            // ckb_space
            // 
            this.ckb_space.AutoSize = true;
            this.ckb_space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_space.Location = new System.Drawing.Point(3, 219);
            this.ckb_space.Name = "ckb_space";
            this.ckb_space.Size = new System.Drawing.Size(14, 23);
            this.ckb_space.TabIndex = 19;
            this.ckb_space.UseVisualStyleBackColor = true;
            // 
            // num_rbutton
            // 
            this.num_rbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_rbutton.Location = new System.Drawing.Point(131, 192);
            this.num_rbutton.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_rbutton.Name = "num_rbutton";
            this.num_rbutton.Size = new System.Drawing.Size(54, 21);
            this.num_rbutton.TabIndex = 20;
            this.num_rbutton.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_rbutton.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_space
            // 
            this.num_space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_space.Location = new System.Drawing.Point(131, 219);
            this.num_space.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_space.Name = "num_space";
            this.num_space.Size = new System.Drawing.Size(54, 21);
            this.num_space.TabIndex = 21;
            this.num_space.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_space.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lb_1
            // 
            this.lb_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_1.Location = new System.Drawing.Point(191, 27);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(34, 27);
            this.lb_1.TabIndex = 22;
            this.lb_1.Text = "0";
            this.lb_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_2
            // 
            this.lb_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_2.Location = new System.Drawing.Point(191, 54);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(34, 27);
            this.lb_2.TabIndex = 23;
            this.lb_2.Text = "0";
            this.lb_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_3
            // 
            this.lb_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_3.Location = new System.Drawing.Point(191, 81);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(34, 27);
            this.lb_3.TabIndex = 24;
            this.lb_3.Text = "0";
            this.lb_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_4
            // 
            this.lb_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_4.Location = new System.Drawing.Point(191, 108);
            this.lb_4.Name = "lb_4";
            this.lb_4.Size = new System.Drawing.Size(34, 27);
            this.lb_4.TabIndex = 25;
            this.lb_4.Text = "0";
            this.lb_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_5
            // 
            this.lb_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_5.Location = new System.Drawing.Point(191, 135);
            this.lb_5.Name = "lb_5";
            this.lb_5.Size = new System.Drawing.Size(34, 27);
            this.lb_5.TabIndex = 26;
            this.lb_5.Text = "0";
            this.lb_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_rbutton
            // 
            this.lb_rbutton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_rbutton.Location = new System.Drawing.Point(191, 189);
            this.lb_rbutton.Name = "lb_rbutton";
            this.lb_rbutton.Size = new System.Drawing.Size(34, 27);
            this.lb_rbutton.TabIndex = 27;
            this.lb_rbutton.Text = "0";
            this.lb_rbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_space
            // 
            this.lb_space.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_space.Location = new System.Drawing.Point(191, 216);
            this.lb_space.Name = "lb_space";
            this.lb_space.Size = new System.Drawing.Size(34, 29);
            this.lb_space.TabIndex = 28;
            this.lb_space.Text = "0";
            this.lb_space.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // timer5
            // 
            this.timer5.Interval = 1000;
            this.timer5.Tick += new System.EventHandler(this.timer5_Tick);
            // 
            // timer_rbutton
            // 
            this.timer_rbutton.Interval = 1000;
            this.timer_rbutton.Tick += new System.EventHandler(this.timer_rbutton_Tick);
            // 
            // timer_space
            // 
            this.timer_space.Interval = 1000;
            this.timer_space.Tick += new System.EventHandler(this.timer_space_Tick);
            // 
            // cbo_datlist
            // 
            this.cbo_datlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_datlist.FormattingEnabled = true;
            this.cbo_datlist.Location = new System.Drawing.Point(21, 342);
            this.cbo_datlist.Name = "cbo_datlist";
            this.cbo_datlist.Size = new System.Drawing.Size(152, 20);
            this.cbo_datlist.TabIndex = 8;
            this.cbo_datlist.SelectedIndexChanged += new System.EventHandler(this.cbo_datlist_SelectedIndexChanged);
            // 
            // tb_datname
            // 
            this.tb_datname.Location = new System.Drawing.Point(199, 342);
            this.tb_datname.Name = "tb_datname";
            this.tb_datname.Size = new System.Drawing.Size(146, 21);
            this.tb_datname.TabIndex = 9;
            // 
            // timer_main
            // 
            this.timer_main.Interval = 1000;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 374);
            this.Controls.Add(this.tb_datname);
            this.Controls.Add(this.cbo_datlist);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_reload);
            this.Controls.Add(this.lb_classname);
            this.Controls.Add(this.lb_handleno);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.cbo_list);
            this.Name = "frmMain";
            this.Text = "키후킹";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_space)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_list;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lb_handleno;
        private System.Windows.Forms.Label lb_classname;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox ckb_1;
        private System.Windows.Forms.CheckBox ckb_2;
        private System.Windows.Forms.CheckBox ckb_3;
        private System.Windows.Forms.CheckBox ckb_4;
        private System.Windows.Forms.CheckBox ckb_5;
        private System.Windows.Forms.ComboBox cbo_key_1;
        private System.Windows.Forms.ComboBox cbo_key_2;
        private System.Windows.Forms.ComboBox cbo_key_3;
        private System.Windows.Forms.ComboBox cbo_key_4;
        private System.Windows.Forms.ComboBox cbo_key_5;
        private System.Windows.Forms.NumericUpDown num_1;
        private System.Windows.Forms.NumericUpDown num_2;
        private System.Windows.Forms.NumericUpDown num_3;
        private System.Windows.Forms.NumericUpDown num_4;
        private System.Windows.Forms.NumericUpDown num_5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Timer timer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckb_rbutton;
        private System.Windows.Forms.CheckBox ckb_space;
        private System.Windows.Forms.NumericUpDown num_rbutton;
        private System.Windows.Forms.NumericUpDown num_space;
        private System.Windows.Forms.Timer timer_rbutton;
        private System.Windows.Forms.Timer timer_space;
        private System.Windows.Forms.ComboBox cbo_datlist;
        private System.Windows.Forms.TextBox tb_datname;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_3;
        private System.Windows.Forms.Label lb_4;
        private System.Windows.Forms.Label lb_5;
        private System.Windows.Forms.Label lb_rbutton;
        private System.Windows.Forms.Label lb_space;
        private System.Windows.Forms.Timer timer_main;
    }
}

