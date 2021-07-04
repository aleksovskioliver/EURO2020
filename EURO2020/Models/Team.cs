using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EURO2020.Models
{
    public class Team
    {
        public Team()
        {
            players = new List<Player>();
        }
        [Key]
        public int id { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        [Display (Name = "National Flag")]
        public string ImgURL { get; set; }
        [Required]
        public float Points { get; set; }

        public virtual ICollection<Player> players { get; set; }
    }
}