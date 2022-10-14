using System.ComponentModel.DataAnnotations;

namespace TestCkEditor.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string EmpDescription { get; set; }
    }
}
