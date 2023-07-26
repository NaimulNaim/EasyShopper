using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShopper.Domain.Model.Base;

namespace EasyShopper.Domain.Model.Entity
{
    internal class Role : BaseEntity
    {
        [Key]
        public int ModuleId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }
        [MaxLength(100)]
        public string? status  { get; set; }
    }
}
