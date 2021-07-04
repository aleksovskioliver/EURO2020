using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EURO2020.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Number { get; set; }
        [Display(Name = "Player photo")]
        public string ImgURL { get; set; }
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Age must be a positive number > 0")]
        public int Age { get; set; }
        public int Goals { get; set; }
        
    }
}