using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDashboard.Models
{
    public class RegisterVM
    {
        [Required]
        [MinLength(1)]
        [EmailAddress]
        public string email {get;set;}
        [Required]
        [MinLength(1)]
        public string first {get;set;}
        [Required]
        [MinLength(1)]
        public string last {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        public string password {get;set;}
        [Required]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("password")]
        public string confirm {get;set;}
    }
}
