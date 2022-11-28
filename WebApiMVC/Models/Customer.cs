using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMVC.Models
{
    public class Customer
    {

        [Display(Name = "GPID")]
        public int GPID { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Display(Name = "MobileNo")]
        public string MobileNo { get; set; }
        [Display(Name = "ExpiryDate")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
        [Display(Name = "CVV")]
        public string CVV { get; set; }
    }
}