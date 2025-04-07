using System.ComponentModel.DataAnnotations;

namespace Online_Medicine_Donation.DataModel
{
    public class Login
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please select the role")]
        public string? Role { get; set; }

    }
}
