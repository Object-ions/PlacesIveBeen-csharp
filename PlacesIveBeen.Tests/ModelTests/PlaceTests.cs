using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesIveBeen.Models;
using System;

namespace PlacesIvBeen.Tests
{
  [TestClass]
  public class PlaceTests : IDisposable
  {
    public void Dispose()
    {
      Place.ClearAll();
    }
    //teardown method

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_PlaceList()
    {
      List<Place> newList = new List<Place> { };

      List<Place> result = Place.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsListOfCities_PlaceList()
    {
      //Arrange
      string city1 = "London";
      string city2 = "Portland";
      Place newPlace1 = new Place(city1);
      // newPlace1 = London;
      Place newPlace2 = new Place(city2);
      // newPlace2 = Portland;
      List<Place> newList = new List<Place> { newPlace1, newPlace2 };

      //Act
      List<Place> result = Place.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}