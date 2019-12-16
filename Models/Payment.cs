using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerBackend.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public String paymentNum { get; set; }
        public decimal amount { get; set; }
        public int category_id { get; set; }
    }
}