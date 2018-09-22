using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnd.Models
{
    [Table("Navigation")]
    public class Navigation
    {
        [Key]
        public int ID { set; get; }

        [MaxLength(256)]
        public string NavName { set; get; }
        [MaxLength(20)]
        public string NavColor { set; get; }
    }
}