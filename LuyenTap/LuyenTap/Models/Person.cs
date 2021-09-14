using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LuyenTap.Models
{
    public class Person
    {
        [Key]
        [Required(ErrorMessage ="ID Không được để trống")]
        public string PersonID { get; set; }
        [Required(ErrorMessage = "Tên Không được để trống")]
        public string PersonName { get; set; }
    }
}