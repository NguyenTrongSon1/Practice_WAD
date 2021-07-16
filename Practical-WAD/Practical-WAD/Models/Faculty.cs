using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Practical_WAD.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}