using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnd.Models
{
    [Table("Header")]
    public class Header
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        
        public string PathImageProfier { set; get; }
        [MaxLength(256)]
        public string HeaderName { set; get; }
        public string Text { set; get; }
    }
}