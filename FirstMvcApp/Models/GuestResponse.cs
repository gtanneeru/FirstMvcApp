using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using FirstMvcApp;

namespace FirstMvcApp.Models
{
    public class GuestResponse
    {
        [Required (ErrorMessage= "Please Enter your Name")]
        public string Name { get; set; }
       [Required (ErrorMessage ="Please enter your email address")]
       [RegularExpression(".+\\@.+\\..+", ErrorMessage ="Please Enter a valid email Address")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Please enter Your Phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please Specify whether u ar attending?")]
        public bool? WillAttend { get; set; }  //? allows null

    }
}