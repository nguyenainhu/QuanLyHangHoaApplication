using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoaApplication
{
    public struct LoaiHang
    {
        public string CategoryID;
        public string CategoryName;
    }

    public struct MatHang
    {
        public string tenHang;
        public string maHang;
        public string hanDung;
        public string congTySanXuat;
        public string namSanXuat;
        public LoaiHang loaihang;
    }

    public static class DataContainer
    {
        public static List<LoaiHang> categoryList = new List<LoaiHang>();
        public static List<MatHang> productList = new List<MatHang>();

        public static void addCategory(string id, string name)
        {
            categoryList.Add(new LoaiHang() { CategoryID = "123", CategoryName = "nuoc ngot"});
        }

        public static void deleteCategory()
        {
            categoryList.RemoveAt(0);
        }

        public static void editCategory()
        {

        }

        public static void addProduct(string id, string name)
        {
            categoryList.Add(new LoaiHang() { CategoryID = "123", CategoryName = "nuoc ngot" });
        }

        public static void deleteProduct()
        {
            categoryList.RemoveAt(0);
        }

        public static void editProduct()
        {

        }
    }
}
