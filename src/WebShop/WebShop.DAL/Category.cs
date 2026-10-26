using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL
{
    public class Category
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(1500)]
        public string? Description { get; set; }

    }
}
