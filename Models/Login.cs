#pragma warning disable CS8618
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Wedding_Planner.Models;

public class Login
{
    [Required]
    [EmailAddress]
    public string EmailLogin { get; set; }        
    
    [Required]
    [DataType(DataType.Password)]
    [MinLength(8, ErrorMessage = "Password requires 8 values as minimum")]
    [PasswordPropertyText]
    public string Password { get; set; }
}