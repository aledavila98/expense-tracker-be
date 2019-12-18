using System;
using System.ComponentModel.DataAnnotations;
namespace ExpenseTrackerBackend.Models
{
    public class Payment
    {
        public int ID { get; set; }
        public String paymentNum { get; set; }
        public decimal amount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}