using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHangHoaApplication
{
    public partial class FormProductInput : Form
    {
        private MatHang tmp = new MatHang();
        public FormProductInput()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            tmp.ProductId = textBoxProductId.Text;
            tmp.ProductName = textBoxProductName.Text;
            tmp.ProductCompany = textBoxProductCompany.Text;
            tmp.ProductDate = textBoxProductDate.Text;
            tmp.ProductExpire = textBoxProductExpire.Text;

            DataContainer.addProduct(tmp);
        }

        private void FormProductInput_Load(object sender, EventArgs e)
        {
            comboBoxProductCategory.DataSource = DataContainer.categoryList;
            comboBoxProductCategory.DisplayMember = "CategoryName";
        }

        private void comboBoxProductCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if(cb.SelectedValue != null)
            {
                LoaiHang category = cb.SelectedValue as LoaiHang;
                tmp.ProductCategory = category;
            }

        }
    }
}
