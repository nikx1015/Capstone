using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Tag
    {
        [Required]
        public int TagId { get; set; }

        [Required]
        public int Title { get; set; }
    }
}
