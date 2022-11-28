using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiMVC.Models
{
    public class TransactionDetail
    {
        [Display(Name = "TransactionId")]
        public int TransactionId { get; set; }
        [Display(Name = "GPID")]
        public int GPID { get; set; }
        [Display(Name = "TransactionDate")]
        public Nullable<System.DateTime> TransactionDate { get; set; }
        [Display(Name = "Amount")]
        public string Amount { get; set; }
        [Display(Name = "Status")]
        public string Status { get; set; }
    }
}