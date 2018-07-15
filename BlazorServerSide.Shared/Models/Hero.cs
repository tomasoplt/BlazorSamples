using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorServerSide.Shared.Models
{
    public class Hero
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
