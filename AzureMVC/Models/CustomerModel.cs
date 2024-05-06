using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace AzureMVC.Models
{
    public class Customer
    {
        [Key]
        public string? CustomerId { get; set; }
        public string? Companyname { get; set; }
        public string? ContactName {  get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
       
        public string? Country { get; set; }
    }

    public class CustomersDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } 
        public CustomersDbContext(DbContextOptions<CustomersDbContext> options):base(options) 
        {
            
        }
    }
}
