﻿namespace RoseOnline
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
            this.cbo_datlist = new System.Windows.Forms.ComboBox();
            this.tb_datname = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_only_keys = new System.Windows.Forms.ComboBox();
            this.ckb_only = new System.Windows.Forms.CheckBox();
            this.btn_only_add = new System.Windows.Forms.Button();
            this.btn_only_clear = new System.Windows.Forms.Button();
            this.dgv_only = new System.Windows.Forms.DataGridView();
            this.col_only_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_only_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_only_sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_only_ing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_only_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbo_group_keys = new System.Windows.Forms.ComboBox();
            this.ckb_group = new System.Windows.Forms.CheckBox();
            this.btn_group_add = new System.Windows.Forms.Button();
            this.btn_group_clear = new System.Windows.Forms.Button();
            this.tb_group_sec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
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
=======
            this.lb_group_ing = new System.Windows.Forms.Label();
            this.dgv_group = new System.Windows.Forms.DataGridView();
            this.col_group_check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.col_group_key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_group_sec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_group_ing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_group_del = new System.Windows.Forms.DataGridViewButtonColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_only)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_group)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_list
            // 
            this.cbo_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_list.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_list.FormattingEnabled = true;
            this.cbo_list.Location = new System.Drawing.Point(3, 3);
            this.cbo_list.Name = "cbo_list";
            this.cbo_list.Size = new System.Drawing.Size(144, 20);
            this.cbo_list.TabIndex = 0;
            this.cbo_list.SelectedIndexChanged += new System.EventHandler(this.cbo_list_SelectedIndexChanged);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_start.Location = new System.Drawing.Point(386, 12);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(66, 140);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(386, 158);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(66, 115);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "정지";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(273, 15);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(75, 72);
            this.btn_check.TabIndex = 3;
            this.btn_check.Text = "창확인";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // lb_handleno
            // 
            this.lb_handleno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_handleno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_handleno.Location = new System.Drawing.Point(3, 29);
            this.lb_handleno.Name = "lb_handleno";
            this.lb_handleno.Size = new System.Drawing.Size(144, 23);
            this.lb_handleno.TabIndex = 4;
            this.lb_handleno.Text = "123456";
            this.lb_handleno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_classname
            // 
            this.lb_classname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_classname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_classname.Location = new System.Drawing.Point(153, 29);
            this.lb_classname.Name = "lb_classname";
            this.lb_classname.Size = new System.Drawing.Size(99, 23);
            this.lb_classname.TabIndex = 5;
            this.lb_classname.Text = "메모장";
            this.lb_classname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reload
            // 
            this.btn_reload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reload.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_reload.Location = new System.Drawing.Point(153, 3);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(99, 23);
            this.btn_reload.TabIndex = 6;
            this.btn_reload.Text = "갱신";
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // cbo_datlist
            // 
            this.cbo_datlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_datlist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_datlist.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbo_datlist.FormattingEnabled = true;
            this.cbo_datlist.Location = new System.Drawing.Point(3, 55);
            this.cbo_datlist.Name = "cbo_datlist";
            this.cbo_datlist.Size = new System.Drawing.Size(144, 20);
            this.cbo_datlist.TabIndex = 8;
            this.cbo_datlist.SelectedIndexChanged += new System.EventHandler(this.cbo_datlist_SelectedIndexChanged);
            // 
            // tb_datname
            // 
            this.tb_datname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_datname.Location = new System.Drawing.Point(153, 55);
            this.tb_datname.Name = "tb_datname";
            this.tb_datname.Size = new System.Drawing.Size(99, 21);
            this.tb_datname.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel2.Controls.Add(this.cbo_list, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_datname, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.btn_reload, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbo_datlist, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_handleno, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_classname, 1, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(255, 80);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 175);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "개별";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.cbo_only_keys, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb_only, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_only_add, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_only_clear, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_only, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
<<<<<<< HEAD
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
=======
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(356, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // cbo_only_keys
            // 
            this.cbo_only_keys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_only_keys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_only_keys.FormattingEnabled = true;
            this.cbo_only_keys.Items.AddRange(new object[] {
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
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
<<<<<<< HEAD
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
=======
            this.cbo_only_keys.Location = new System.Drawing.Point(24, 3);
            this.cbo_only_keys.Name = "cbo_only_keys";
            this.cbo_only_keys.Size = new System.Drawing.Size(75, 20);
            this.cbo_only_keys.TabIndex = 0;
            // 
            // ckb_only
            // 
            this.ckb_only.AutoSize = true;
            this.ckb_only.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_only.Location = new System.Drawing.Point(3, 3);
            this.ckb_only.Name = "ckb_only";
            this.ckb_only.Size = new System.Drawing.Size(15, 23);
            this.ckb_only.TabIndex = 1;
            this.ckb_only.UseVisualStyleBackColor = true;
            // 
            // btn_only_add
            // 
            this.btn_only_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_only_add.Location = new System.Drawing.Point(105, 3);
            this.btn_only_add.Name = "btn_only_add";
            this.btn_only_add.Size = new System.Drawing.Size(75, 23);
            this.btn_only_add.TabIndex = 2;
            this.btn_only_add.Text = "추가";
            this.btn_only_add.UseVisualStyleBackColor = true;
            this.btn_only_add.Click += new System.EventHandler(this.btn_only_add_Click);
            // 
            // btn_only_clear
            // 
            this.btn_only_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_only_clear.Location = new System.Drawing.Point(186, 3);
            this.btn_only_clear.Name = "btn_only_clear";
            this.btn_only_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_only_clear.TabIndex = 3;
            this.btn_only_clear.Text = "초기화";
            this.btn_only_clear.UseVisualStyleBackColor = true;
            this.btn_only_clear.Click += new System.EventHandler(this.btn_only_clear_Click);
            // 
            // dgv_only
            // 
            this.dgv_only.AllowUserToAddRows = false;
            this.dgv_only.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_only.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_only_check,
            this.col_only_key,
            this.col_only_sec,
            this.col_only_ing,
            this.col_only_del});
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_only, 5);
            this.dgv_only.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_only.Location = new System.Drawing.Point(3, 32);
            this.dgv_only.MultiSelect = false;
            this.dgv_only.Name = "dgv_only";
            this.dgv_only.RowHeadersVisible = false;
            this.dgv_only.RowTemplate.Height = 23;
            this.dgv_only.Size = new System.Drawing.Size(350, 115);
            this.dgv_only.TabIndex = 4;
            this.dgv_only.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_only_CellClick);
            // 
            // col_only_check
            // 
            this.col_only_check.HeaderText = "CK";
            this.col_only_check.Name = "col_only_check";
            this.col_only_check.Width = 30;
            // 
            // col_only_key
            // 
            this.col_only_key.HeaderText = "키";
            this.col_only_key.Name = "col_only_key";
            this.col_only_key.ReadOnly = true;
            // 
            // col_only_sec
            // 
            this.col_only_sec.HeaderText = "sec";
            this.col_only_sec.Name = "col_only_sec";
            // 
            // col_only_ing
            // 
            this.col_only_ing.HeaderText = "ing";
            this.col_only_ing.Name = "col_only_ing";
            this.col_only_ing.ReadOnly = true;
            this.col_only_ing.Width = 50;
            // 
            // col_only_del
            // 
            this.col_only_del.HeaderText = "삭제";
            this.col_only_del.Name = "col_only_del";
            this.col_only_del.Text = "삭제";
            this.col_only_del.Width = 60;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 175);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "그룹";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.cbo_group_keys, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ckb_group, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_group_add, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btn_group_clear, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_group_sec, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.lb_group_ing, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgv_group, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(430, 150);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // cbo_group_keys
            // 
            this.cbo_group_keys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbo_group_keys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_group_keys.FormattingEnabled = true;
            this.cbo_group_keys.Items.AddRange(new object[] {
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
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
<<<<<<< HEAD
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
=======
            this.cbo_group_keys.Location = new System.Drawing.Point(24, 3);
            this.cbo_group_keys.Name = "cbo_group_keys";
            this.cbo_group_keys.Size = new System.Drawing.Size(75, 20);
            this.cbo_group_keys.TabIndex = 1;
            // 
            // ckb_group
            // 
            this.ckb_group.AutoSize = true;
            this.ckb_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckb_group.Location = new System.Drawing.Point(3, 3);
            this.ckb_group.Name = "ckb_group";
            this.ckb_group.Size = new System.Drawing.Size(15, 23);
            this.ckb_group.TabIndex = 2;
            this.ckb_group.UseVisualStyleBackColor = true;
            // 
            // btn_group_add
            // 
            this.btn_group_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_group_add.Location = new System.Drawing.Point(105, 3);
            this.btn_group_add.Name = "btn_group_add";
            this.btn_group_add.Size = new System.Drawing.Size(75, 23);
            this.btn_group_add.TabIndex = 3;
            this.btn_group_add.Text = "추가";
            this.btn_group_add.UseVisualStyleBackColor = true;
            this.btn_group_add.Click += new System.EventHandler(this.btn_group_add_Click);
            // 
            // btn_group_clear
            // 
            this.btn_group_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_group_clear.Location = new System.Drawing.Point(186, 3);
            this.btn_group_clear.Name = "btn_group_clear";
            this.btn_group_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_group_clear.TabIndex = 4;
            this.btn_group_clear.Text = "초기화";
            this.btn_group_clear.UseVisualStyleBackColor = true;
            this.btn_group_clear.Click += new System.EventHandler(this.btn_group_clear_Click);
            // 
            // tb_group_sec
            // 
            this.tb_group_sec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_group_sec.Location = new System.Drawing.Point(287, 3);
            this.tb_group_sec.Name = "tb_group_sec";
            this.tb_group_sec.Size = new System.Drawing.Size(50, 21);
            this.tb_group_sec.TabIndex = 5;
            this.tb_group_sec.Text = "1";
            this.tb_group_sec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(343, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "sec";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
<<<<<<< HEAD
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
=======
            // lb_group_ing
            // 
            this.lb_group_ing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_group_ing.Location = new System.Drawing.Point(379, 0);
            this.lb_group_ing.Name = "lb_group_ing";
            this.lb_group_ing.Size = new System.Drawing.Size(48, 29);
            this.lb_group_ing.TabIndex = 7;
            this.lb_group_ing.Text = "0";
            this.lb_group_ing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_group
            // 
            this.dgv_group.AllowUserToAddRows = false;
            this.dgv_group.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_group.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_group_check,
            this.col_group_key,
            this.col_group_sec,
            this.col_group_ing,
            this.col_group_del});
            this.tableLayoutPanel3.SetColumnSpan(this.dgv_group, 8);
            this.dgv_group.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_group.Location = new System.Drawing.Point(3, 32);
            this.dgv_group.MultiSelect = false;
            this.dgv_group.Name = "dgv_group";
            this.dgv_group.RowHeadersVisible = false;
            this.dgv_group.RowTemplate.Height = 23;
            this.dgv_group.Size = new System.Drawing.Size(424, 115);
            this.dgv_group.TabIndex = 8;
            this.dgv_group.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_group_CellClick);
            // 
            // col_group_check
            // 
            this.col_group_check.HeaderText = "CK";
            this.col_group_check.Name = "col_group_check";
            this.col_group_check.Width = 30;
            // 
            // col_group_key
            // 
            this.col_group_key.HeaderText = "키";
            this.col_group_key.Name = "col_group_key";
            this.col_group_key.ReadOnly = true;
            // 
            // col_group_sec
            // 
            this.col_group_sec.HeaderText = "sec";
            this.col_group_sec.Name = "col_group_sec";
            // 
            // col_group_ing
            // 
            this.col_group_ing.HeaderText = "ing";
            this.col_group_ing.Name = "col_group_ing";
            this.col_group_ing.ReadOnly = true;
            this.col_group_ing.Width = 50;
            // 
            // col_group_del
            // 
            this.col_group_del.HeaderText = "삭제";
            this.col_group_del.Name = "col_group_del";
            this.col_group_del.Text = "삭제";
            this.col_group_del.Width = 60;
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
<<<<<<< HEAD
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
=======
>>>>>>> 5e4352146bfce17bd6b98b8ea81e4c8b2b15a069
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Name = "frmMain";
            this.Text = "키후킹";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_only)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_group)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_list;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label lb_handleno;
        private System.Windows.Forms.Label lb_classname;
        private System.Windows.Forms.Button btn_reload;
        private System.Windows.Forms.ComboBox cbo_datlist;
        private System.Windows.Forms.TextBox tb_datname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbo_only_keys;
        private System.Windows.Forms.ComboBox cbo_group_keys;
        private System.Windows.Forms.CheckBox ckb_only;
        private System.Windows.Forms.Button btn_only_add;
        private System.Windows.Forms.Button btn_only_clear;
        private System.Windows.Forms.CheckBox ckb_group;
        private System.Windows.Forms.Button btn_group_add;
        private System.Windows.Forms.Button btn_group_clear;
        private System.Windows.Forms.TextBox tb_group_sec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_group_ing;
        private System.Windows.Forms.DataGridView dgv_only;
        private System.Windows.Forms.DataGridView dgv_group;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_only_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_only_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_only_sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_only_ing;
        private System.Windows.Forms.DataGridViewButtonColumn col_only_del;
        private System.Windows.Forms.DataGridViewCheckBoxColumn col_group_check;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_group_key;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_group_sec;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_group_ing;
        private System.Windows.Forms.DataGridViewButtonColumn col_group_del;
    }
}

