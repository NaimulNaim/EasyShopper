using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShopper.Domain.Model.Base;

namespace EasyShopper.Domain.Model
{
    internal class Menu : BaseEntity
    {   
        [Key]
        public int MenuId { get; set; }
        [MaxLength(100)]
        public string? Name { get; set; }

        public int Serial { get; set; }

        public int ModuleId { get; set; }
        [MaxLength(20)]
        public string? Status { get; set; }
        [MaxLength(250)]
        public string? Href { get; set; }
        [MaxLength(100)]
        public string? Area { get; set; }
        [MaxLength(100)]
        public string? Control { get; set; }
        [MaxLength(100)]
        public string? Action { get; set; }
        [MaxLength(20)]
        public string? Isshow { get; set; }

        public int? parentId { get; set; }

        public int? MenuLevel { get; set; }
    }
}
