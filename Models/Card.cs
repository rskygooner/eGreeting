using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eGreeting.Models
{
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CardId { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "NameCard cannot more than 50 characters. ")]
        public string CardName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public string ImageName { get; set; }

        [EnumDataType(typeof(Status))]
        public Status IsActive { get; set; } = Status.Active;

        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
        public DateTime? DateCreated { get; set; }
    }
}
