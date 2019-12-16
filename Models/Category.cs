using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTrackerBackend.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string name { get; set; }
    }
}