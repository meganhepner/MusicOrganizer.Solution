using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;
using System.Collections.Generic;

namespace MusicOrganizer.Controllers
{
  public class ArtistsController : Controller
  {
    [HttpGet("/artists")]
    public ActionResult Index()
    {
      List<Artist> artistList = Artist.GetAll();
      return View(artistList);
    }

    [HttpGet("/artists/{id}")]
    public ActionResult Show(int id)
    {
      Artist foundArtist = Artist.FindArtist(id);
      return View(foundArtist);
    }
  }
}