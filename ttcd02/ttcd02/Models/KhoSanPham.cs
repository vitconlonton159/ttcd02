using System.Collections.Generic;
using System.Linq;

namespace ttcd02.Models
{
    public class KhoSanPham
    {
        private List<Product> _products = new List<Product>();
        private int _nextId = 1;

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? GetById(int id) // Cho phép trả về null nếu không tìm thấy sản phẩm
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = _nextId++; // Tự động gán ID cho sản phẩm mới
            _products.Add(product); // Thêm sản phẩm vào danh sách
        }

        public void Update(Product product)
        {
            var existingProduct = GetById(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Description = product.Description;
                existingProduct.Price = product.Price;
                existingProduct.Stock = product.Stock;
            }
        }

        public void Delete(int id)
        {
            var product = GetById(id);
            if (product != null)
            {
                _products.Remove(product);
            }
        }
    }
}
