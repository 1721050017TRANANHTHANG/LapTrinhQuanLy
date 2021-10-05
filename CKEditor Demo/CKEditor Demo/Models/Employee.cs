namespace CKEditor_Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee
    {
        [Key]
        public string PersonID { get; set; }

        public string Company { get; set; }

        public string Address { get; set; }

        [Required]
        public string PersonName { get; set; }
    }
}
