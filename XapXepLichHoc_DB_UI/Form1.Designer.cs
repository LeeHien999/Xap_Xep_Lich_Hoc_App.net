namespace XapXepLichHoc_DB_UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mamon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_thu = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_them = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_weekBegin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_weekEnd = new System.Windows.Forms.TextBox();
            this.cb_thoiGian = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tinChi = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.cb_dsmonhienthi = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_tongchi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_test = new System.Windows.Forms.Label();
            this.cb_dstinchi = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_dsthu = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.lb_tongmon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã môn học";
            // 
            // txt_mamon
            // 
            this.txt_mamon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mamon.Location = new System.Drawing.Point(166, 497);
            this.txt_mamon.Name = "txt_mamon";
            this.txt_mamon.Size = new System.Drawing.Size(220, 27);
            this.txt_mamon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(719, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thứ";
            // 
            // cb_thu
            // 
            this.cb_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_thu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thu.FormattingEnabled = true;
            this.cb_thu.Location = new System.Drawing.Point(782, 496);
            this.cb_thu.Name = "cb_thu";
            this.cb_thu.Size = new System.Drawing.Size(220, 28);
            this.cb_thu.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 300);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Location = new System.Drawing.Point(663, 606);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(93, 36);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm lịch";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 560);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tuan hoc";
            // 
            // txt_weekBegin
            // 
            this.txt_weekBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weekBegin.Location = new System.Drawing.Point(166, 553);
            this.txt_weekBegin.Name = "txt_weekBegin";
            this.txt_weekBegin.Size = new System.Drawing.Size(93, 27);
            this.txt_weekBegin.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(273, 560);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "-";
            // 
            // txt_weekEnd
            // 
            this.txt_weekEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_weekEnd.Location = new System.Drawing.Point(294, 553);
            this.txt_weekEnd.Name = "txt_weekEnd";
            this.txt_weekEnd.Size = new System.Drawing.Size(92, 27);
            this.txt_weekEnd.TabIndex = 11;
            // 
            // cb_thoiGian
            // 
            this.cb_thoiGian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_thoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thoiGian.FormattingEnabled = true;
            this.cb_thoiGian.Location = new System.Drawing.Point(782, 552);
            this.cb_thoiGian.Name = "cb_thoiGian";
            this.cb_thoiGian.Size = new System.Drawing.Size(220, 28);
            this.cb_thoiGian.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(679, 560);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Thời gian";
            // 
            // cb_tinChi
            // 
            this.cb_tinChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tinChi.FormattingEnabled = true;
            this.cb_tinChi.Location = new System.Drawing.Point(166, 614);
            this.cb_tinChi.Name = "cb_tinChi";
            this.cb_tinChi.Size = new System.Drawing.Size(220, 28);
            this.cb_tinChi.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 622);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số tín chỉ";
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(782, 606);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(93, 36);
            this.btn_delete.TabIndex = 16;
            this.btn_delete.Text = "Xóa lịch";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(909, 606);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(93, 36);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Sửa lịch";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // cb_dsmonhienthi
            // 
            this.cb_dsmonhienthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dsmonhienthi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dsmonhienthi.FormattingEnabled = true;
            this.cb_dsmonhienthi.Location = new System.Drawing.Point(107, 118);
            this.cb_dsmonhienthi.Name = "cb_dsmonhienthi";
            this.cb_dsmonhienthi.Size = new System.Drawing.Size(220, 28);
            this.cb_dsmonhienthi.TabIndex = 19;
            this.cb_dsmonhienthi.SelectedIndexChanged += new System.EventHandler(this.cb_dsmonhienthi_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Lọc";
            // 
            // txt_tongchi
            // 
            this.txt_tongchi.AutoSize = true;
            this.txt_tongchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tongchi.Location = new System.Drawing.Point(818, 83);
            this.txt_tongchi.Name = "txt_tongchi";
            this.txt_tongchi.Size = new System.Drawing.Size(0, 20);
            this.txt_tongchi.TabIndex = 21;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1033, 30);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem1,
            this.thoátToolStripMenuItem,
            this.thoátToolStripMenuItem1});
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Tùy chọn";
            // 
            // đăngXuấtToolStripMenuItem1
            // 
            this.đăngXuấtToolStripMenuItem1.Name = "đăngXuấtToolStripMenuItem1";
            this.đăngXuấtToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.đăngXuấtToolStripMenuItem1.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem1.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem1_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.thoátToolStripMenuItem.Text = "Thông tin tài khoản";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem1
            // 
            this.thoátToolStripMenuItem1.Name = "thoátToolStripMenuItem1";
            this.thoátToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.thoátToolStripMenuItem1.Text = "Thoát";
            this.thoátToolStripMenuItem1.Click += new System.EventHandler(this.thoátToolStripMenuItem1_Click);
            // 
            // txt_test
            // 
            this.txt_test.AutoSize = true;
            this.txt_test.Font = new System.Drawing.Font("RixLoveFool", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_test.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txt_test.Location = new System.Drawing.Point(39, 682);
            this.txt_test.Name = "txt_test";
            this.txt_test.Size = new System.Drawing.Size(71, 24);
            this.txt_test.TabIndex = 23;
            this.txt_test.Text = "Hiển thị";
            this.txt_test.Click += new System.EventHandler(this.txt_test_Click);
            // 
            // cb_dstinchi
            // 
            this.cb_dstinchi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dstinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dstinchi.FormattingEnabled = true;
            this.cb_dstinchi.Location = new System.Drawing.Point(107, 79);
            this.cb_dstinchi.Name = "cb_dstinchi";
            this.cb_dstinchi.Size = new System.Drawing.Size(220, 28);
            this.cb_dstinchi.TabIndex = 24;
            this.cb_dstinchi.SelectedIndexChanged += new System.EventHandler(this.cb_dstinchi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Teal;
            this.label8.Location = new System.Drawing.Point(349, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "Số Chỉ (-1 = All)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(349, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Mã Môn học";
            // 
            // cb_dsthu
            // 
            this.cb_dsthu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dsthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_dsthu.FormattingEnabled = true;
            this.cb_dsthu.Location = new System.Drawing.Point(107, 31);
            this.cb_dsthu.Name = "cb_dsthu";
            this.cb_dsthu.Size = new System.Drawing.Size(220, 28);
            this.cb_dsthu.TabIndex = 27;
            this.cb_dsthu.SelectedIndexChanged += new System.EventHandler(this.cb_dsthu_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Teal;
            this.label10.Location = new System.Drawing.Point(349, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Thứ";
            // 
            // btn_filter
            // 
            this.btn_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filter.Location = new System.Drawing.Point(566, 105);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(141, 36);
            this.btn_filter.TabIndex = 29;
            this.btn_filter.Text = "Reset Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_tongmon
            // 
            this.lb_tongmon.AutoSize = true;
            this.lb_tongmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tongmon.ForeColor = System.Drawing.Color.Teal;
            this.lb_tongmon.Location = new System.Drawing.Point(818, 126);
            this.lb_tongmon.Name = "lb_tongmon";
            this.lb_tongmon.Size = new System.Drawing.Size(93, 20);
            this.lb_tongmon.TabIndex = 30;
            this.lb_tongmon.Text = "Tổng Môn: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 723);
            this.Controls.Add(this.lb_tongmon);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_dsthu);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_dstinchi);
            this.Controls.Add(this.txt_test);
            this.Controls.Add(this.txt_tongchi);
            this.Controls.Add(this.cb_dsmonhienthi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cb_tinChi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_thoiGian);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_weekEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_weekBegin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_thu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mamon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Xắp xếp lịch học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mamon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_thu;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_weekBegin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_weekEnd;
        private System.Windows.Forms.ComboBox cb_thoiGian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tinChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.ComboBox cb_dsmonhienthi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txt_tongchi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem1;
        private System.Windows.Forms.Label txt_test;
        private System.Windows.Forms.ComboBox cb_dstinchi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_dsthu;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.Label lb_tongmon;
    }
}

