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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataContainer.categoryList;
        }

        private void Reload_DataGridView()
        {
            BindingContext[dataGridView1.DataSource].SuspendBinding();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataContainer.categoryList;
            BindingContext[dataGridView1.DataSource].ResumeBinding();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            FormCategoryInput formCategoryInput = new FormCategoryInput();
            var result = formCategoryInput.ShowDialog();
            if (result == DialogResult.OK)
            {
                Reload_DataGridView();
            }

        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            FormCategoryInput formCategoryInput = new FormCategoryInput();
            formCategoryInput.Tag = "edit";
            int x = dataGridView1.CurrentCell.RowIndex;

            formCategoryInput.SetCategoryName(dataGridView1.Rows[x].Cells[1].Value.ToString(), dataGridView1.Rows[x].Cells[0].Value.ToString());
            var result = formCategoryInput.ShowDialog();

            if (result == DialogResult.OK)
            {
                Reload_DataGridView();
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[x].Cells[0].Value.ToString();
            DataContainer.deleteCategory(int.Parse(id));
            Reload_DataGridView();
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            List<LoaiHang> result = new List<LoaiHang>();
            result = DataContainer.searchCategory(textBoxSearch.Text);
            if (result.Count > 0)
            {
                BindingContext[dataGridView1.DataSource].SuspendBinding();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = result;
                BindingContext[dataGridView1.DataSource].ResumeBinding();

            } else
            {
                MessageBox.Show(textBoxSearch.Text + " not exist in category list");
            }
        }
    }
}
