﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Kindergarten_Management_System.Data
{
    public class LeaveType
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int DefaultDays { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
