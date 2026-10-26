using System.ComponentModel.DataAnnotations;

namespace WebShop.DAL
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string FirstName { get; set; }
        [StringLength(150)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(200)]
        public string Password { get; set; }
    }
}
