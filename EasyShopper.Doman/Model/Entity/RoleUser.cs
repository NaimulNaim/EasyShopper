using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShopper.Domain.Model.Base;

namespace EasyShopper.Domain.Model.Entity
{
    internal class RoleUser : BaseEntity
    {
        [Key]
        public int RoleUserId { get; set; } 

        public string? RoleId { get; set; }

        public int UserId { get; set; }
        [MaxLength(20)]
        public string? Status { get; set; }

        
    }
}
