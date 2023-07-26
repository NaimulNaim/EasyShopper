using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyShopper.Domain.Model.Base
{
    public class BaseEntity
    {
        [MaxLength(20)]
        public string? EnteredBy { get; set; }
        [MaxLength(40)]
        public string? EnteredTerminal { get; set; }

        public DateTime? EnteredDate { get; set; }
        [MaxLength(20)]
        public string? UpdatedBy { get; set; }
        [MaxLength(40)]
        public string? UpdateTerminal { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
