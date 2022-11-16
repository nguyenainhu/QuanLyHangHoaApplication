namespace QuanLyHangHoaApplication
{
    partial class FormApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleApplication = new System.Windows.Forms.Label();
            this.btnNhapLoaiHang = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleApplication
            // 
            this.titleApplication.AutoSize = true;
            this.titleApplication.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleApplication.ForeColor = System.Drawing.Color.Black;
            this.titleApplication.Location = new System.Drawing.Point(188, 39);
            this.titleApplication.Name = "titleApplication";
            this.titleApplication.Size = new System.Drawing.Size(414, 37);
            this.titleApplication.TabIndex = 0;
            this.titleApplication.Text = "Chương trình quản lý hàng hóa";
            // 
            // btnNhapLoaiHang
            // 
            this.btnNhapLoaiHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNhapLoaiHang.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhapLoaiHang.Location = new System.Drawing.Point(188, 110);
            this.btnNhapLoaiHang.Name = "btnNhapLoaiHang";
            this.btnNhapLoaiHang.Size = new System.Drawing.Size(160, 90);
            this.btnNhapLoaiHang.TabIndex = 1;
            this.btnNhapLoaiHang.Text = "Nhập loại hàng";
            this.btnNhapLoaiHang.UseVisualStyleBackColor = false;
            this.btnNhapLoaiHang.Click += new System.EventHandler(this.btnNhapLoaiHang_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(188, 242);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(160, 90);
            this.button5.TabIndex = 5;
            this.button5.Text = "Danh sách loại hàng";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(455, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 90);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nhập hàng hóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(455, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 90);
            this.button3.TabIndex = 7;
            this.button3.Text = "Danh sách hàng hóa";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnNhapLoaiHang);
            this.Controls.Add(this.titleApplication);
            this.Name = "FormApplication";
            this.Text = "FormApplication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleApplication;
        private Button btnNhapLoaiHang;
        private Button button5;
        private Button button2;
        private Button button3;
    }
}