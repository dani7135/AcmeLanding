using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace ClassLibrary
{
    public class Submission_Model { 
     public int Id { get; set; }
        
    // [Range(18, 102, ErrorMessage = "Must be older than 18 to submit")]
    [Required]
    [DisplayName("Current age")]
    public int Age { get; set; }
    [Required]
    [Display(Name = " First Name")]
    public string FirstName { get; set; }
    [Required]
    [Display(Name = " Last Name")]
    public string LastName { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Range(10000000, 99999999, ErrorMessage = "Enter vaild 8 digits serial number")]
    [Display(Name = "Valid product serial number")]
    public int SerialNumber { get; set; }

    }
}
