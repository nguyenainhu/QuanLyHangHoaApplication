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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }
        private void FormProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataContainer.productList;
        }

        private void reload_DataGridView()
        {
            BindingContext[dataGridView1.DataSource].SuspendBinding();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataContainer.productList;
            BindingContext[dataGridView1.DataSource].ResumeBinding();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FormProductInput productInput = new FormProductInput();
            var result = productInput.ShowDialog();
            if(result == DialogResult.OK)
            {
                reload_DataGridView();
            }
        }
    }
}
