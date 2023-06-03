using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Core_01.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required, StringLength(40), Display(Name ="Employee Name")]
        public string EmployeeName { get; set; }
        [Required,Column(TypeName ="Date"), Display(Name = "Join Date")]

        public DateTime JoinDate{ get; set; }
        [Required, StringLength(20)]
        public string Contact { get; set; }
    }
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }
        public DbSet<Employee> Employees { get; set; }
    }
}
