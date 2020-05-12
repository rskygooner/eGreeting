using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class User
    {
        [Key]
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
        [StringLength(50)]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        [EnumDataType(typeof(Gender))]
        public Gender  Gender { get; set; }

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

        [Display(Name = "Role")]
        [EnumDataType(typeof(Role))]
        public Role Role { get; set; }

        [EnumDataType(typeof(Status))]
        public Status IsActive { get; set; }
    }
    public enum Gender : byte
    {
        Female = 0,
        Male = 1,
    }
    public enum Role : byte
    {
        Admin = 0,
        User = 1,
    }
    public enum Status : byte
    {
        Inactive = 0,
        Active = 1,
    }
}
