using Microsoft.AspNetCore.Mvc;
using CDOrganizer.Models;
using System.Collections.Generic;

namespace CDOrganizer.Controllers
{
    public class ArtistsController : Controller
    {
        [HttpGet("/Artists")]
        public ActionResult Artists()
        {
            List<Artist> allArtists = Artist.GetAll();
            return View(allArtists);
        }

        [HttpPost("/Artists/new")]
        public ActionResult Create()
        {
            Artist newArtist = new Artist(Request.Form["new-artist"]);
            return View("CreateForm");
        }

        [HttpGet("/Artists/new")]
        public ActionResult CreateForm()
        {
            return View("CreateForm");
        }

        [HttpGet("/Artists/{id}")]
        public ActionResult Details(int id)
        {
            List<Artist> allArtists = Artist.GetAll();
            return View("Details", allArtists[id-1]);
        }

        [HttpGet("/Artists/{id}/new")]
        public ActionResult CreateAlbum(int id)
        {
            List<Artist> allArtists = Artist.GetAll();
            return View("CreateAlbum", allArtists[id-1]);
        }

        [HttpPost("/Artists/{id}/new")]
        public ActionResult PostAlbum(int id)
        {
            Album newAlbum = new Album(Request.Form["new-album"]);

            List<Artist> allArtists = Artist.GetAll();
            return View("CreateAlbum", allArtists[id-1]);
        }


    }
}
