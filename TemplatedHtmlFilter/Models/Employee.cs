using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TemplatedHtmlFilter.Models
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string name { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Isonline")]
        public bool IsOnline { get; set; }

        [Display(Name = "Date Of Birth")]
        [DataType(DataType.Date )]
        public DateTime dob { get; set; }

        [Display(Name = "Birth Time")]
        [DataType(DataType.Time)]
        public DateTime dobtime { get; set; }
    }
}