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
    public partial class FormLoaiHang : Form
    {
        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataContainer.addCategory("1gh", "abc");
        }
    }
}
