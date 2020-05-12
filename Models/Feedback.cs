using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class Feedback
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FeedbackId { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Subject { get; set; }

        [Required]
        [StringLength(1000, MinimumLength = 3)]
        public string Content { get; set; }

        [EnumDataType(typeof(Check))]
        public Check IsChecked { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
    }
    public enum Check : byte
    {
        Uncheck = 0,
        Check = 1,
    }
}
