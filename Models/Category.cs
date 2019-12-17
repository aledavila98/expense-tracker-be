using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ExpenseTrackerBackend.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string name { get; set; }

        public ICollection<Payment> Payments { get; set; }
    }
}