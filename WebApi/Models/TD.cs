using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class TD
    {
        public int TransactionId { get; set; }
        public int GPID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public string Amount { get; set; }
        public string Status { get; set; }
    }
}