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
    public partial class FormCategoryInput : Form
    {
        private int id;
        public FormCategoryInput()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoryName = TextBoxCategory.Text;
            if (Tag == "edit")
            {
                DataContainer.editCategory(id, categoryName);
            } else
            {
                Random random = new Random();
                int categoryId = random.Next();
                DataContainer.addCategory(categoryId, categoryName);
            }
        }

        private void FormCategoryInput_Load(object sender, EventArgs e)
        {
           
        }

        public void SetCategoryName(string name, string id)
        {
            TextBoxCategory.Text = name;
            this.id = int.Parse(id);
        }
    }
}
