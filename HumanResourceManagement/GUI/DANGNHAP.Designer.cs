namespace QUAN_LY_NHAN_SU
{
    partial class frm_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tenDN = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.btn_dangNhap = new System.Windows.Forms.Button();
            this.btn_dangKi = new System.Windows.Forms.Button();
            this.btn_quenmatkhau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RosyBrown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.RosyBrown;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Đăng Nhập : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.RosyBrown;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 157);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật Khẩu :";
            // 
            // txt_tenDN
            // 
            this.txt_tenDN.Location = new System.Drawing.Point(196, 106);
            this.txt_tenDN.Margin = new System.Windows.Forms.Padding(2);
            this.txt_tenDN.Name = "txt_tenDN";
            this.txt_tenDN.Size = new System.Drawing.Size(174, 20);
            this.txt_tenDN.TabIndex = 1;
            this.txt_tenDN.TextChanged += new System.EventHandler(this.txt_tenDN_TextChanged);
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(196, 160);
            this.txt_MK.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(174, 20);
            this.txt_MK.TabIndex = 2;
            this.txt_MK.UseSystemPasswordChar = true;
            this.txt_MK.TextChanged += new System.EventHandler(this.txt_MK_TextChanged);
            // 
            // btn_dangNhap
            // 
            this.btn_dangNhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangNhap.Location = new System.Drawing.Point(79, 250);
            this.btn_dangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangNhap.Name = "btn_dangNhap";
            this.btn_dangNhap.Size = new System.Drawing.Size(92, 50);
            this.btn_dangNhap.TabIndex = 3;
            this.btn_dangNhap.Text = "Đăng Nhập";
            this.btn_dangNhap.UseVisualStyleBackColor = false;
            this.btn_dangNhap.Click += new System.EventHandler(this.btn_dangNhap_Click);
            // 
            // btn_dangKi
            // 
            this.btn_dangKi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangKi.Location = new System.Drawing.Point(246, 250);
            this.btn_dangKi.Margin = new System.Windows.Forms.Padding(2);
            this.btn_dangKi.Name = "btn_dangKi";
            this.btn_dangKi.Size = new System.Drawing.Size(92, 50);
            this.btn_dangKi.TabIndex = 3;
            this.btn_dangKi.Text = "Đăng Kí";
            this.btn_dangKi.UseVisualStyleBackColor = false;
            this.btn_dangKi.Click += new System.EventHandler(this.btn_dangKi_Click);
            // 
            // btn_quenmatkhau
            // 
            this.btn_quenmatkhau.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_quenmatkhau.Location = new System.Drawing.Point(410, 250);
            this.btn_quenmatkhau.Margin = new System.Windows.Forms.Padding(2);
            this.btn_quenmatkhau.Name = "btn_quenmatkhau";
            this.btn_quenmatkhau.Size = new System.Drawing.Size(88, 50);
            this.btn_quenmatkhau.TabIndex = 4;
            this.btn_quenmatkhau.Text = "Quên Mật Khẩu";
            this.btn_quenmatkhau.UseVisualStyleBackColor = false;
            this.btn_quenmatkhau.Click += new System.EventHandler(this.btn_quenmatkhau_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(787, 499);
            this.Controls.Add(this.btn_quenmatkhau);
            this.Controls.Add(this.btn_dangKi);
            this.Controls.Add(this.btn_dangNhap);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.txt_tenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_DangNhap";
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_tenDN;
        public System.Windows.Forms.TextBox txt_MK;
        public System.Windows.Forms.Button btn_dangNhap;
        public System.Windows.Forms.Button btn_dangKi;
        private System.Windows.Forms.Button btn_quenmatkhau;
    }
}