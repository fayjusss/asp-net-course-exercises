using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace KaraokeApp.Models
{
    public class Playlist
    {
        public int ID { get; set; }

        [DisplayName("Song")]
        public int SongID { get; set; }


        [DisplayName("Singer")]
        public int SingerID { get; set; }

        public virtual Song Song { get; set; }
        public virtual Singer Singer { get; set; }

    }
}