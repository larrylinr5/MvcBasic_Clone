using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Info
    {
        
        [Display(Name = "ID")]
        public int Id { get; set; }


        [Required(ErrorMessage = "請輸入文字")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "最少要三個字")]
        [Display(Name = "姓名")]
        public string Name { get; set; }


        [RegularExpression(@"^\d{4}\-?\d{3}\-?\d{3}$", ErrorMessage = "需為09xx-xxx-xxx格式")]
        [Required(ErrorMessage = "請輸入文字")]
        [Display(Name = "電話")]
        public string Phone { get; set; }


        [Required(ErrorMessage = "請輸入文字")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "請輸入文字")]
        [Display(Name = "性別")]
        public string Gender { get; set; }
    }
}