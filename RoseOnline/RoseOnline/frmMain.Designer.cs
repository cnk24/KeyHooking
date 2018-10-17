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
            this.ckb_1 = new System.Windows.Forms.CheckBox();
            this.ckb_2 = new System.Windows.Forms.CheckBox();
            this.ckb_3 = new System.Windows.Forms.CheckBox();
            this.ckb_4 = new System.Windows.Forms.CheckBox();
            this.ckb_5 = new System.Windows.Forms.CheckBox();
            this.cbo_key_1 = new System.Windows.Forms.ComboBox();
            this.cbo_key_2 = new System.Windows.Forms.ComboBox();
            this.cbo_key_3 = new System.Windows.Forms.ComboBox();
            this.cbo_key_4 = new System.Windows.Forms.ComboBox();
            this.cbo_key_5 = new System.Windows.Forms.ComboBox();
            this.num_1 = new System.Windows.Forms.NumericUpDown();
            this.num_2 = new System.Windows.Forms.NumericUpDown();
            this.num_3 = new System.Windows.Forms.NumericUpDown();
            this.num_4 = new System.Windows.Forms.NumericUpDown();
            this.num_5 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.timer5 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_5)).BeginInit();
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
            this.btn_start.Location = new System.Drawing.Point(237, 84);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(126, 66);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "시작";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(237, 161);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(126, 68);
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
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.44118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.55882F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Controls.Add(this.ckb_1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ckb_2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ckb_3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ckb_4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ckb_5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbo_key_5, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.num_1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.num_2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.num_3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.num_4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.num_5, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(208, 155);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // ckb_1
            // 
            this.ckb_1.AutoSize = true;
            this.ckb_1.Location = new System.Drawing.Point(3, 3);
            this.ckb_1.Name = "ckb_1";
            this.ckb_1.Size = new System.Drawing.Size(15, 14);
            this.ckb_1.TabIndex = 0;
            this.ckb_1.UseVisualStyleBackColor = true;
            // 
            // ckb_2
            // 
            this.ckb_2.AutoSize = true;
            this.ckb_2.Location = new System.Drawing.Point(3, 34);
            this.ckb_2.Name = "ckb_2";
            this.ckb_2.Size = new System.Drawing.Size(15, 14);
            this.ckb_2.TabIndex = 1;
            this.ckb_2.UseVisualStyleBackColor = true;
            // 
            // ckb_3
            // 
            this.ckb_3.AutoSize = true;
            this.ckb_3.Location = new System.Drawing.Point(3, 65);
            this.ckb_3.Name = "ckb_3";
            this.ckb_3.Size = new System.Drawing.Size(15, 14);
            this.ckb_3.TabIndex = 2;
            this.ckb_3.UseVisualStyleBackColor = true;
            // 
            // ckb_4
            // 
            this.ckb_4.AutoSize = true;
            this.ckb_4.Location = new System.Drawing.Point(3, 96);
            this.ckb_4.Name = "ckb_4";
            this.ckb_4.Size = new System.Drawing.Size(15, 14);
            this.ckb_4.TabIndex = 3;
            this.ckb_4.UseVisualStyleBackColor = true;
            // 
            // ckb_5
            // 
            this.ckb_5.AutoSize = true;
            this.ckb_5.Location = new System.Drawing.Point(3, 127);
            this.ckb_5.Name = "ckb_5";
            this.ckb_5.Size = new System.Drawing.Size(15, 14);
            this.ckb_5.TabIndex = 4;
            this.ckb_5.UseVisualStyleBackColor = true;
            // 
            // cbo_key_1
            // 
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
            this.cbo_key_1.Location = new System.Drawing.Point(24, 3);
            this.cbo_key_1.Name = "cbo_key_1";
            this.cbo_key_1.Size = new System.Drawing.Size(108, 20);
            this.cbo_key_1.TabIndex = 5;
            // 
            // cbo_key_2
            // 
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
            this.cbo_key_2.Location = new System.Drawing.Point(24, 34);
            this.cbo_key_2.Name = "cbo_key_2";
            this.cbo_key_2.Size = new System.Drawing.Size(108, 20);
            this.cbo_key_2.TabIndex = 6;
            // 
            // cbo_key_3
            // 
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
            this.cbo_key_3.Location = new System.Drawing.Point(24, 65);
            this.cbo_key_3.Name = "cbo_key_3";
            this.cbo_key_3.Size = new System.Drawing.Size(108, 20);
            this.cbo_key_3.TabIndex = 7;
            // 
            // cbo_key_4
            // 
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
            this.cbo_key_4.Location = new System.Drawing.Point(24, 96);
            this.cbo_key_4.Name = "cbo_key_4";
            this.cbo_key_4.Size = new System.Drawing.Size(108, 20);
            this.cbo_key_4.TabIndex = 8;
            // 
            // cbo_key_5
            // 
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
            this.cbo_key_5.Location = new System.Drawing.Point(24, 127);
            this.cbo_key_5.Name = "cbo_key_5";
            this.cbo_key_5.Size = new System.Drawing.Size(108, 20);
            this.cbo_key_5.TabIndex = 9;
            // 
            // num_1
            // 
            this.num_1.Location = new System.Drawing.Point(138, 3);
            this.num_1.Name = "num_1";
            this.num_1.Size = new System.Drawing.Size(66, 21);
            this.num_1.TabIndex = 10;
            this.num_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_2
            // 
            this.num_2.Location = new System.Drawing.Point(138, 34);
            this.num_2.Name = "num_2";
            this.num_2.Size = new System.Drawing.Size(66, 21);
            this.num_2.TabIndex = 11;
            this.num_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_3
            // 
            this.num_3.Location = new System.Drawing.Point(138, 65);
            this.num_3.Name = "num_3";
            this.num_3.Size = new System.Drawing.Size(66, 21);
            this.num_3.TabIndex = 12;
            this.num_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_4
            // 
            this.num_4.Location = new System.Drawing.Point(138, 96);
            this.num_4.Name = "num_4";
            this.num_4.Size = new System.Drawing.Size(66, 21);
            this.num_4.TabIndex = 13;
            this.num_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_5
            // 
            this.num_5.Location = new System.Drawing.Point(138, 127);
            this.num_5.Name = "num_5";
            this.num_5.Size = new System.Drawing.Size(66, 21);
            this.num_5.TabIndex = 14;
            this.num_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 243);
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
            ((System.ComponentModel.ISupportInitialize)(this.num_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_5)).EndInit();
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
    }
}

