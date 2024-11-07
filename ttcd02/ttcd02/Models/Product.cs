namespace ttcd02.Models
{
    public class Product
    {
        public int Id { get; set; }

        // Đánh dấu các thuộc tính là nullable hoặc khởi tạo giá trị mặc định
        public string Name { get; set; } = string.Empty; // Khởi tạo giá trị mặc định
        public string Description { get; set; } = string.Empty; // Khởi tạo giá trị mặc định
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
