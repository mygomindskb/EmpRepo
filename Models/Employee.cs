using System.ComponentModel.DataAnnotations;

namespace EmpWebApplication.Models
{
    public class Employee
    {
        [Key]
        public int Eid { get; set; }
        [Required]
        public string? Ename { get; set; }
        [Required]
        public decimal Salary { get; set; }
    }
}
