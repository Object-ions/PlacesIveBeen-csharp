using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesIveBeen.Models;
using System;

namespace PlacesIvBeen.Tests
{
  [TestClass]
  public class PlaceTests
  {
    [TestMethod]
    public void PlaceCostructor_CreatesInstanceOfPlace_Place()
    {
      // Arrange
      Place newPlace = new Place("test");
      // Act

      // Assert
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
  }
}