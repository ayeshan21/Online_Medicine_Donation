using System.ComponentModel.DataAnnotations;

namespace Online_Medicine_Donation.Areas.User.Models
{
    public class UserRegistration
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20, ErrorMessage = "Name must be less than or equal to 20 characters")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20, ErrorMessage = "Name must be less than or equal to 20 characters")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(100)]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20, ErrorMessage = "Phone number must be less than or equal to 20 digits")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20, ErrorMessage = "Email must be less than or equal to 20 characters")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(30, ErrorMessage = "Please write valid NID number")]
        public string? NID { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "Please fill out this field")]
        [StringLength(20)]
        public string? ConfirmPassword { get; set; }

    }
}
