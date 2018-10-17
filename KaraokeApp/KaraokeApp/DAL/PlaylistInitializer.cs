using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KaraokeApp.Models;

namespace KaraokeApp.DAL
{
    public class PlaylistInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PlaylistContext>
    {
        protected override void Seed(PlaylistContext context)
        {
            var Songs = new List<Song>
            {
                new Song{Title="Hey Jude",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Something",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Blackbird",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Anna (Go To Him)",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Yesterday",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Let it be",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },
                new Song{Title="Michelle",Genre="Rock", Artist="Beatles", Album="Abbey Road", Key="G" },


            };
            Songs.ForEach(s => context.Songs.Add(s));
            context.SaveChanges();

            var Singers = new List<Singer>
            {
                new Singer{FirstName="Fayjus", LastName="Salehin", Phone="+358401234567"},
                new Singer{FirstName="Dair", LastName="Baidauletov", Phone="+358407654321"},
                new Singer{FirstName="Zhanna", LastName="Kresteva", Phone="0400987654"},
                new Singer{FirstName="Roberts", LastName="Plorin", Phone="0400456789"}
            };
            Singers.ForEach(s => context.Singers.Add(s));
            context.SaveChanges();

            var Playlists = new List<Playlist>
            {
                new Playlist { SongID=3, SingerID=1},
                new Playlist { SongID=4, SingerID=2},
                new Playlist { SongID=2, SingerID=3},
                new Playlist { SongID=1, SingerID=4},
                new Playlist { SongID=3, SingerID=1}

            };
            Playlists.ForEach(s => context.Playlists.Add(s));
            context.SaveChanges();
        }
    }
}