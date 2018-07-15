﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorServerSide.Shared.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string City { get; set; }
    }
}
