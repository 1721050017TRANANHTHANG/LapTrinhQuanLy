using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace KetNoi.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        [Required(ErrorMessage = "Ten Person khong duoc de trong")]
        [MinLength(3)]
        public string PersonName { get; set; }
        [Required(ErrorMessage = "Dia chi Adress khong duoc de trong")]
        public string Adress { get; set; }
    }
}