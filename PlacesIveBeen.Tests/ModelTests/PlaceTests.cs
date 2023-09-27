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
      // Assert
      Assert.AreEqual(typeof(Place), newPlace.GetType());
    }
    [TestMethod]
    public void GetCityName_ReturnsCityName_String()
    {
      // Arrange
      string cityName = "London";
      // Act
      Place newPlace = new Place(cityName);
      string result = newPlace.CityName;
      // Assert
      Assert.AreEqual(cityName, result);
    }

    [TestMethod]
    public void SetCityName_SetCityName_String()
    {
      //Arrange
      string cityName = "London";
      Place newPlace = new Place(cityName);

      //Act
      string updatedCityName = "Portland";
      newPlace.CityName = updatedCityName;
      string result = newPlace.CityName;

      //Assert
      Assert.AreEqual(updatedCityName, result);
    }
  }
}