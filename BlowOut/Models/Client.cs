using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlowOut.Models
{   //VARIABLES FOR THE CLIENT OBJECT AND TABLE
    //INCLDUED ANNOTOTAIONS FOR ALL, INCLUDING HIDDEN FOR ID VALUE
    [Table("Client")]
    public class Client
    {
        [Key]
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Required(ErrorMessage = "First name is required")]
        [DisplayName("First name")]
        public string First_Name { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [DisplayName("Last Name")]
        public string Last_Name { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [DisplayName("Address")]
        [StringLength(30)]
        public string address { get; set; }

        [Required(ErrorMessage = "City is required")]
        [DisplayName("City")]
        [StringLength(30)]
        public string city { get; set; }

        [Required(ErrorMessage = "State is required")]
        [DisplayName("State")]
        [StringLength(30)]
        public string state { get; set; }

        [Required(ErrorMessage = "Zip is Required")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        [DisplayName("Zip Code")]
        public int zip { get; set; }

        [Required(ErrorMessage = "Email address is required")]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage = "Not a valid email address")]
        [StringLength(30)]
        public string email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string phone { get; set; }


    }
}