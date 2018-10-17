using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace KaraokeApp.Models
{
    public class Singer
    {
        [Required]
        [StringLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Phone]
        public string Phone { get; set; }

        public virtual ICollection<Playlist> Playlist { get; set; }

    }
}