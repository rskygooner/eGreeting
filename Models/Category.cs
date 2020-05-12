using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Category Name cannot more than 50 characters. ")]
        public string CategoryName { get; set; }

        [EnumDataType(typeof(Status))]
        public Status IsActive { get; set; }
    }
}
