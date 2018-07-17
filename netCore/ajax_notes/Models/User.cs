using System;
using System.ComponentModel.DataAnnotations;

namespace User.Models
{
       public class User
       {
           [Required]
           public string first_name{set;get;}
           [Required]
           public string last_name{set;get;}
           [Required]
           [EmailAddress]
           public string email_address{set;get;}
           [Required]
           [DataType(DataType.Password)]
           public string password{set;get;}
           [Required]
           [Compare("Password", ErrorMessage= "Your passwords must match.")]
           public string confirm_pw{set;get;}
       }
}