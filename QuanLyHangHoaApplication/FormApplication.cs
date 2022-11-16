namespace QuanLyHangHoaApplication
{   
    public partial class FormApplication : Form
    {
        //public static FormApplication instance;
        public FormApplication()
        {
            InitializeComponent();
           /* instance = this;
            matHangList = new List<MatHang>();*/
        }
        
        private void btnNhapLoaiHang_Click(object sender, EventArgs e)
        {
           FormLoaiHang formLoaiHang = new FormLoaiHang();
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