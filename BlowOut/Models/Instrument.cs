using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BlowOut.Models
{
    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [DisplayName("First name")]
        [StringLength(50)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Type is required")]
        [DisplayName("Type")]
        [StringLength(50)]
        public string Type { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [DisplayName("Price")]
        public int Price { get; set; }

        [DisplayName("Client ID")]
        public int? Client_ID { get; set; }
    }
}