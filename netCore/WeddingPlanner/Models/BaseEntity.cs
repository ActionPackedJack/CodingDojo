using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WeddingPlanner.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id{get;set;}
    }
}