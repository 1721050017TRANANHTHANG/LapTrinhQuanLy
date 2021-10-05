namespace CKEditor_Demo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Article
    {
        [StringLength(50)]
        public string ArticleID { get; set; }

        [StringLength(50)]
        public string Author { get; set; }

        [Column(TypeName = "ntext")]
        public string ArticleContent { get; set; }
    }
}
