using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnd.Models
{
    [Table("Footer")]
    public class Footer
    {
        [Key]
        public int ID { set; get; }
        [MaxLength(256)]
        public string ColumName { set; get; }
        public string Text { set; get; }
        
    }
}