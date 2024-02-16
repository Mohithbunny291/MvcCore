using System.ComponentModel.DataAnnotations;

namespace MvcCore.Models
{
    public class Employee
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public Double Salary { get; set; }
        public DateTime Doj { get; set; }
    }
}
