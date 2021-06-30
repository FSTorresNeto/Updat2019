using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Display(Name = "Base Salary")]

        public double BaseSalary { get; set; }
        [Display(Name = "Brith Date")]
        
        public DateTime BirthDate { get; set; }

        public Department Department { get; set; }
        public ICollection<SalesRecords> Sales { get; set; } = new List<SalesRecords>();

        public int DepartmentId { get; set; }


        public Seller()
        {

        }

        public Seller(int id, string name, string email, double baseSalary, DateTime birthDate, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BaseSalary = baseSalary;
            BirthDate = birthDate;
            Department = department;
        }

        public void AddSales(SalesRecords sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecords sr)
        {
            Sales.Remove(sr);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
