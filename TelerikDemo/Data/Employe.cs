﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikDemo.Data
{
    public enum Gender
    {
        Male, Female, Unknown
    }
    
    public class Employee
    {
        [Editable(false)]
        public int Id { get; set; }
        public string FirstName { get; set; }
       // [Editable(false)]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName.ToUpper()}";
         [DisplayFormat(DataFormatString = "{0:C}")]
        [Editable(false)]
        public decimal Salary { get; set; } = 2500.5678m;
        public string Email { get; set; }
        public Gender Gender { get; set; }
        //[DisplayFormat(DataFormatString = "{0:yyyy/MMM/dd}")]
        public DateTime DateOfBirth { get; set; }
        public bool IsMarried { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
