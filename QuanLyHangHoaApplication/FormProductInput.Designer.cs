namespace QuanLyHangHoaApplication
{
    partial class FormProductInput
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
            this.labelProductId = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelProductCategory = new System.Windows.Forms.Label();
            this.labelProductDate = new System.Windows.Forms.Label();
            this.labelProductExpire = new System.Windows.Forms.Label();
            this.labelProductCompany = new System.Windows.Forms.Label();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductDate = new System.Windows.Forms.TextBox();
            this.textBoxProductExpire = new System.Windows.Forms.TextBox();
            this.textBoxProductCompany = new System.Windows.Forms.TextBox();
            this.comboBoxProductCategory = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelProductId
            // 
            this.labelProductId.AutoSize = true;
            this.labelProductId.Location = new System.Drawing.Point(25, 38);
            this.labelProductId.Name = "labelProductId";
            this.labelProductId.Size = new System.Drawing.Size(54, 15);
            this.labelProductId.TabIndex = 0;
            this.labelProductId.Text = "Mã hàng";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Location = new System.Drawing.Point(25, 81);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(55, 15);
            this.labelProductName.TabIndex = 1;
            this.labelProductName.Text = "Tên hàng";
            // 
            // labelProductCategory
            // 
            this.labelProductCategory.AutoSize = true;
            this.labelProductCategory.Location = new System.Drawing.Point(25, 120);
            this.labelProductCategory.Name = "labelProductCategory";
            this.labelProductCategory.Size = new System.Drawing.Size(59, 15);
            this.labelProductCategory.TabIndex = 2;
            this.labelProductCategory.Text = "Loại hàng";
            // 
            // labelProductDate
            // 
            this.labelProductDate.AutoSize = true;
            this.labelProductDate.Location = new System.Drawing.Point(274, 38);
            this.labelProductDate.Name = "labelProductDate";
            this.labelProductDate.Size = new System.Drawing.Size(82, 15);
            this.labelProductDate.TabIndex = 3;
            this.labelProductDate.Text = "Ngày sản xuất";
            // 
            // labelProductExpire
            // 
            this.labelProductExpire.AutoSize = true;
            this.labelProductExpire.Location = new System.Drawing.Point(274, 81);
            this.labelProductExpire.Name = "labelProductExpire";
            this.labelProductExpire.Size = new System.Drawing.Size(78, 15);
            this.labelProductExpire.TabIndex = 4;
            this.labelProductExpire.Text = "Ngày hết hạn";
            // 
            // labelProductCompany
            // 
            this.labelProductCompany.AutoSize = true;
            this.labelProductCompany.Location = new System.Drawing.Point(274, 120);
            this.labelProductCompany.Name = "labelProductCompany";
            this.labelProductCompany.Size = new System.Drawing.Size(96, 15);
            this.labelProductCompany.TabIndex = 5;
            this.labelProductCompany.Text = "Công ty sản xuất";
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Location = new System.Drawing.Point(85, 38);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(165, 23);
            this.textBoxProductId.TabIndex = 6;
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(86, 81);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(165, 23);
            this.textBoxProductName.TabIndex = 7;
            // 
            // textBoxProductDate
            // 
            this.textBoxProductDate.Location = new System.Drawing.Point(376, 38);
            this.textBoxProductDate.Name = "textBoxProductDate";
            this.textBoxProductDate.Size = new System.Drawing.Size(165, 23);
            this.textBoxProductDate.TabIndex = 8;
            // 
            // textBoxProductExpire
            // 
            this.textBoxProductExpire.Location = new System.Drawing.Point(376, 81);
            this.textBoxProductExpire.Name = "textBoxProductExpire";
            this.textBoxProductExpire.Size = new System.Drawing.Size(165, 23);
            this.textBoxProductExpire.TabIndex = 9;
            // 
            // textBoxProductCompany
            // 
            this.textBoxProductCompany.Location = new System.Drawing.Point(376, 120);
            this.textBoxProductCompany.Name = "textBoxProductCompany";
            this.textBoxProductCompany.Size = new System.Drawing.Size(165, 23);
            this.textBoxProductCompany.TabIndex = 10;
            // 
            // comboBoxProductCategory
            // 
            this.comboBoxProductCategory.FormattingEnabled = true;
            this.comboBoxProductCategory.Location = new System.Drawing.Point(86, 122);
            this.comboBoxProductCategory.Name = "comboBoxProductCategory";
            this.comboBoxProductCategory.Size = new System.Drawing.Size(164, 23);
            this.comboBoxProductCategory.TabIndex = 11;
            this.comboBoxProductCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductCategory_SelectedValueChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddProduct.Location = new System.Drawing.Point(466, 161);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 29);
            this.btnAddProduct.TabIndex = 12;
            this.btnAddProduct.Text = "Thêm";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // FormProductInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 202);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.comboBoxProductCategory);
            this.Controls.Add(this.textBoxProductCompany);
            this.Controls.Add(this.textBoxProductExpire);
            this.Controls.Add(this.textBoxProductDate);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.textBoxProductId);
            this.Controls.Add(this.labelProductCompany);
            this.Controls.Add(this.labelProductExpire);
            this.Controls.Add(this.labelProductDate);
            this.Controls.Add(this.labelProductCategory);
            this.Controls.Add(this.labelProductName);
            this.Controls.Add(this.labelProductId);
            this.Name = "FormProductInput";
            this.Text = "FormProductInput";
            this.Load += new System.EventHandler(this.FormProductInput_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelProductId;
        private Label labelProductName;
        private Label labelProductCategory;
        private Label labelProductDate;
        private Label labelProductExpire;
        private Label labelProductCompany;
        private TextBox textBoxProductId;
        private TextBox textBoxProductName;
        private TextBox textBoxProductDate;
        private TextBox textBoxProductExpire;
        private TextBox textBoxProductCompany;
        private ComboBox comboBoxProductCategory;
        private Button btnAddProduct;
    }
}