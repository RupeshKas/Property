using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    [Table("City")]
    public class City
    {
        [Key]
        
        public int Id { get; set; }

        [StringLength(30)]
        public string  CityName { get; set; }
    }
}