using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Category { get; set; }

        [StringLength(250)]
        public string? Description { get; set; }
        
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater that 0.")]
        public decimal Amount { get; set; }
    }
}