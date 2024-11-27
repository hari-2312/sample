using System.ComponentModel.DataAnnotations;

namespace Employee_Details.Models
{
    public class Emp_master
    {
        [Key]
        public int Emp_no {  get; set; }
        [Required]
        public string Emp_name {  get; set; }
        [Required]
        public int Emp_phone { get; set; }
        [Required]
        public string Emp_dep {  get; set; }
    }
}
