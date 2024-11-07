using Microsoft.AspNetCore.Mvc;
using ttcd02.Models;

namespace ttcd02.Controllers
{
    public class ProductController : Controller
    {
        private readonly KhoSanPham _repository;

        // Khởi tạo repository
        public ProductController()
        {
            _repository = new KhoSanPham();
        }

        // GET: Product
        public IActionResult Index()
        {
            var products = _repository.GetAll(); // Lấy danh sách sản phẩm
            return View(products); // Hiển thị danh sách sản phẩm
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View(); // Hiển thị form tạo sản phẩm mới
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid) // Kiểm tra xem dữ liệu có hợp lệ không
            {
                _repository.Add(product); // Thêm sản phẩm vào danh sách tạm thời
                return RedirectToAction(nameof(Index)); // Chuyển hướng về trang danh sách sản phẩm
            }
            return View(product); // Nếu có lỗi, hiển thị lại form với dữ liệu đã nhập
        }
    }
}
