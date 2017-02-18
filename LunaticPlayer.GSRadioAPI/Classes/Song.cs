﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace LunaticPlayer.Classes
{
    public class Song
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string ArtistName { get; set; }
        public string CircleName { get; set; }
        public string AlbumName { get; set; }

        public DateTime StartTime { get; set; }
        public DateTime EndTime => StartTime + Duration;

        public TimeSpan Duration { get; set; }
        public TimeSpan PlayedDuration { get; set; }

        public TimeSpan EndDuration => EndTime - DateTime.Now;

        public int ApiSongId { get; set; }
        public int ApiAlbumId { get; set; }

        public string AlbumArtFilename { get; set; }
        public string CirleArtFilename { get; set; }

        public BitmapImage AlbumArt { get; set; }
    }
}


// Startuhrzeit: DateTime.Now - Played