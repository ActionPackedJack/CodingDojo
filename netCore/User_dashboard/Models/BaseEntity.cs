using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace UserDashboard.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id{get;set;}
    }
}