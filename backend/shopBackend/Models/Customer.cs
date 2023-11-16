using System.ComponentModel.DataAnnotations;

namespace shopBackend.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(100)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PhoneNumber { get; set; }
        [Required]
        public string Address { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
