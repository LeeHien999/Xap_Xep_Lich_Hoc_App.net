namespace XapXepLichHoc_DB_UI
{
    partial class frm_info_account
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
            this.lb_masv = new System.Windows.Forms.Label();
            this.lb_tensv = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_khoa = new System.Windows.Forms.Label();
            this.lb_nam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_masv.ForeColor = System.Drawing.Color.Coral;
            this.lb_masv.Location = new System.Drawing.Point(48, 57);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(122, 27);
            this.lb_masv.TabIndex = 1;
            this.lb_masv.Text = "Mã sinh viên";
            // 
            // lb_tensv
            // 
            this.lb_tensv.AutoSize = true;
            this.lb_tensv.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tensv.ForeColor = System.Drawing.Color.Coral;
            this.lb_tensv.Location = new System.Drawing.Point(48, 115);
            this.lb_tensv.Name = "lb_tensv";
            this.lb_tensv.Size = new System.Drawing.Size(129, 27);
            this.lb_tensv.TabIndex = 2;
            this.lb_tensv.Text = "tên sinh viên";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.ForeColor = System.Drawing.Color.Coral;
            this.lb_diachi.Location = new System.Drawing.Point(433, 177);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(72, 27);
            this.lb_diachi.TabIndex = 3;
            this.lb_diachi.Text = "Địa chỉ";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaysinh.ForeColor = System.Drawing.Color.Coral;
            this.lb_ngaysinh.Location = new System.Drawing.Point(48, 177);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(97, 27);
            this.lb_ngaysinh.TabIndex = 4;
            this.lb_ngaysinh.Text = "Ngày sinh";
            // 
            // lb_khoa
            // 
            this.lb_khoa.AutoSize = true;
            this.lb_khoa.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khoa.ForeColor = System.Drawing.Color.Coral;
            this.lb_khoa.Location = new System.Drawing.Point(433, 57);
            this.lb_khoa.Name = "lb_khoa";
            this.lb_khoa.Size = new System.Drawing.Size(53, 27);
            this.lb_khoa.TabIndex = 5;
            this.lb_khoa.Text = "Khoa";
            // 
            // lb_nam
            // 
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("RixLoveFool", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nam.ForeColor = System.Drawing.Color.Coral;
            this.lb_nam.Location = new System.Drawing.Point(433, 115);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(48, 27);
            this.lb_nam.TabIndex = 6;
            this.lb_nam.Text = "Năm";
            // 
            // frm_info_account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 258);
            this.Controls.Add(this.lb_nam);
            this.Controls.Add(this.lb_khoa);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_tensv);
            this.Controls.Add(this.lb_masv);
            this.Name = "frm_info_account";
            this.Text = "thông tin tài khoản";
            this.Load += new System.EventHandler(this.frm_info_account_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.Label lb_tensv;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_khoa;
        private System.Windows.Forms.Label lb_nam;
    }
}