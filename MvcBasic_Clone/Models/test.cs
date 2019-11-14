using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class test
    {
        [Display(Name = "身分證")]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
    }
}