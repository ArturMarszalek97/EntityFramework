using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication7.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
       // [Display(Name = "Imię")]
      //  [Required(ErrorMessage = "Nalezy wypelnic to pole!")]
        public string Firstname { get; set; }
      //  [Display(Name = "Nazwisko")]
       // [Required(ErrorMessage = "Nalezy wypelnic to pole!")]
        public string LastName { get; set; }
        //[Display(Name = "Wiek")]
       // [Required(ErrorMessage = "Nalezy wypelnic to pole!")]
       // [Range(1, 110, ErrorMessage = "Dopuszczany wiek to 1-110 lat")]
        public int Age { get; set; }
    }
}