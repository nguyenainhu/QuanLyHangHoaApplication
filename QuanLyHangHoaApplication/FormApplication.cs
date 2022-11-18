namespace QuanLyHangHoaApplication
{   
    public partial class FormApplication : Form
    {
        public FormApplication()
        {
            InitializeComponent();
        }
        
        private void btnNhapLoaiHang_Click(object sender, EventArgs e)
        {
           FormCategoryInput formLoaiHang = new FormCategoryInput();
           formLoaiHang.ShowDialog();       
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCategory formCategory = new FormCategory();
            formCategory.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormProduct formProduct = new FormProduct();
            formProduct.ShowDialog();
        }
    }
}