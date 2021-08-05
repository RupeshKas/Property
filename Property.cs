using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("Property")]
    public class Property
    {
        [Key]

        public int PId { get; set; }

        [StringLength(30)]
        public string PropertyName { get; set; }

        [StringLength(30)]
        public string PropertyType { get; set; }

        [StringLength(30)]
        public string PropertyDcrp { get; set; }

        public double PropertyPrice { get; set; }
    }
}