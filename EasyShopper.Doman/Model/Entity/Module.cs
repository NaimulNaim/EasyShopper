using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShopper.Domain.Model.Base;

namespace EasyShopper.Domain.Model.Entity
{
    public class Module : BaseEntity
    {   
        [Key]
        public int? ModuleId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }

        [MaxLength(20)]
        public int? Serial { get; set; }

        [MaxLength(100)]
        public string? Status { get; set; }
        
    }
}
