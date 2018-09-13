using System;
using System.Collections.Generic;

namespace CDOrganizer.Models
{
    public class Artist
    {
        public string Name {get; set;}

        private int _id;
        private static List<Artist> _artists = new List<Artist> {};
        private List<Album> _artistsAlbums = new List<Album> {};

        public Artist(string name)
        {
            Name = name;
            _artists.Add(this);
            _id = _artists.Count;
        }

        public int GetId()
        {
            return _id;
        }

        public static List<Artist> GetAll()
        {
          return _artists;
        }

        public List<Album> GetAlbums()
        {
            return _artistsAlbums;
        }
    }
}
