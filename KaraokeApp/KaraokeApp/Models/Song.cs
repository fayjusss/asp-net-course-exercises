using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace KaraokeApp.Models
{
    public class Song
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Genre { get; set; }

        [Required]
        [StringLength(100)]
        public string Artist { get; set; }

        [Required]
        [StringLength(100)]
        public string Album { get; set; }

        [Required]
        [StringLength(2)]
        public string Key { get; set; }

        public virtual ICollection<Playlist> Playlist { get; set; }

    }
}
