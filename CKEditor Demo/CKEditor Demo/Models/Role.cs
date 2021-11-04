using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CKEditor_Demo.Models
{
    public partial class Role
    {
        [StringLength(10)]
        public string RoleID { get; set; }
        [StringLength(50)]
        public string RoleName { get; set; }
    }
}