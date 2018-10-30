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
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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

