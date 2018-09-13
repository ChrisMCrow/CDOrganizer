using System;
using System.Collections.Generic;

namespace CDOrganizer.Models
{
    public class Album
    {
        public string Name{ get; set;}
        private int _id;
        private static List<Album> _allAlbums = new List<Album> {};

        public Album(string name)
        {
            Name = name;
            _allAlbums.Add(this);
            _id = _allAlbums.Count;
        }

        public int GetId()
        {
            return _id;
        }

        public List<Album> GetAll()
        {
            return _allAlbums;
        }


    }
}
