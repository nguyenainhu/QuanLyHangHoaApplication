using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoaApplication
{
    public class LoaiHang
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }

    public struct MatHang
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public LoaiHang ProductCategory { get; set; }
        public string ProductExpire { get; set; }
        public string ProductDate { get; set; }
        public string ProductCompany { get; set; }
    }

    public static class DataContainer
    {
        public static List<LoaiHang> categoryList = new List<LoaiHang>();
        public static List<MatHang> productList = new List<MatHang>();

        public static void addCategory(int id, string name)
        {
            categoryList.Add(new LoaiHang() { CategoryID = id, CategoryName = name});
        }

        public static void deleteCategory(int id)
        {
            var index = categoryList.FindIndex(item => item.CategoryID == id);
            categoryList.RemoveAt(index);
        }

        public static void editCategory(int id, string name)
        {
            var index = categoryList.FindIndex(item => item.CategoryID == id);
            categoryList[index].CategoryName = name;
        }

        public static List<LoaiHang> searchCategory(string searchValue)
        {
            List<LoaiHang> tmp = new List<LoaiHang>();
            foreach (var item in categoryList)
            {
                if (item.CategoryName.Contains(searchValue))
                {
                   tmp.Add(item);
                }
            }
            return tmp;
        }

        public static void addProduct(MatHang item)
        {
            productList.Add(item);
        }

        public static void deleteProduct(string id)
        {
            var index = productList.FindIndex(item => item.ProductId == id);
            productList.RemoveAt(index);
        }

        public static void editProduct(MatHang value)
        {
            var index = productList.FindIndex(item => item.ProductId == value.ProductId);
            productList[index] = value;
        }

        public static List<MatHang> searchProduct(string searchValue)
        {
            List<MatHang> tmp = new List<MatHang>();
            foreach (var item in productList)
            {
                if (item.ProductName.Contains(searchValue))
                {
                    tmp.Add(item);
                }
            }
            return tmp;
        }
    }
}
