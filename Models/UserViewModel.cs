using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class UserViewModel
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "User Name")]
        [RegularExpression(@"[^\s]+", ErrorMessage = "Cannot use special character!")]
        public string UserName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8)]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        [Display(Name = "Gender")]
        [EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }

        [Required]
        [RegularExpression("[0-9]{8,10}", ErrorMessage = "Phone Number must be from 8 - 10 digits")]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(50, MinimumLength = 10)]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
