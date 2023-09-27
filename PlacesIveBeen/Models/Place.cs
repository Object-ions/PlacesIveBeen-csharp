
namespace PlacesIveBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }
    // private static List<Place> _instance = new List<Place> { };

    public Place(string cityName)
    {
      CityName = cityName;
      // _instances.Add(this);
    }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }
  }
}
// private static List<Item> _instances = new List<Item> { };

// public Item(string description)
// {
//   Description = description;
//   _instances.Add(this);
//   Id = _instances.Count;
//   monument = ;
//   jurnal = ;
// }
