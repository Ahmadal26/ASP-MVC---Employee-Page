using System.ComponentModel.DataAnnotations;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class Employee
    {
        [Required]
        public string EmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Department { get; set; }



      //  public DateTime DateOfBirth { get; set; }
       // public string FavoriteColor { get; set; }

    }

}
