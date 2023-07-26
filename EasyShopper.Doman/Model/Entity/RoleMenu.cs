using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyShopper.Domain.Model.Base;

namespace EasyShopper.Domain.Model.Entity
{
    internal class RoleMenu : BaseEntity
    {
        [Key]
        public int RoleMenuId { get; set; }
        
        public string? RoleId { get; set;}
        
        public string? MenuId { get; set;}
        [MaxLength(20)]
        public string? Status { get; set;}
        [MaxLength(20)]
        public string? ListPermission { get; set;}
        [MaxLength(20)]
        public string? CreatePermission { get; set; }
        [MaxLength(20)]
        public string? UpdatePermission { get; set; }
        [MaxLength(20)]
        public string? DeletePermission { get; set; }
        [MaxLength(20)]
        public string? DownloadPermission { get; set; }
        [MaxLength(20)]
        public string? ConfirmationPermission { get; set; }
    }
}
