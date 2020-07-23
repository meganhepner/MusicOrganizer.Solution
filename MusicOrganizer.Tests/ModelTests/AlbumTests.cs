using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;
using System.Collections.Generic;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTest : IDisposable
  {
    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CanCreateAlbumObjects_MatchType()
    {
      Album newAlbum = new Album("Graceland", "Paul Simon");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
      Assert.AreEqual("Graceland", newAlbum.AlbumName);
      Assert.AreEqual("Paul Simon", newAlbum.ArtistName);
    }

    [TestMethod]
    public void AlbumList_AlbumsAreAddedToList_ListAdd()
    {
      Album newAlbum = new Album("OK Computer", "Radiohead");
      List<Album> expectedList = new List<Album> { newAlbum };
      CollectionAssert.AreEqual(expectedList, Album.GetAll());
    }
  }
}