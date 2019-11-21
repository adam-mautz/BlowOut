using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Models
{   
    //VARIABLES FOR THE INSTRUMENT OBJECT AND TABLE

    [Table("Instrument")]
    public class Instrument
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string description { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string type { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int price { get; set; }

        [HiddenInput(DisplayValue = false)]
        public int? Client_ID { get; set; }
    }
}