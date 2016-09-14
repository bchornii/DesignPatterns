using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Flyweight_Map
{
    class Program
    {
        public static IMapComponent BuildCity(MapComponentFactory factory)
        {
            var road = new HighwayBuilder(factory, "Main Street")
                          .BuildDirect(0, 2)
                          .BuildDirect(1, 2)
                          .BuildTurnRight(2, 2)
                          .BuildDirect(2, 1)
                          .BuildDirect(2, 0);

            var park = new ParkBuilder(factory, "City Park")
                          .BuildOakTree(0, 0)
                          .BuildAspenTree(1, 0)
                          .BuildAspenTree(1, 1)
                          .BuildAspenTree(0, 1);

            var houses = new HouseBuilder(factory, "House1")
                          .BuildHouse(1, 3)
                          .BuildHouse(3, 1);

            var district = new SmallDistrictBuilder("District 1")
                          .BuildHouseArea(houses.Component)
                          .BuildPark(park.Component)
                          .BuildRoad(road.Component);

            var city = new SmallCityBuilder("New city")
                          .BuildDistrict(district.Component);            

            return city.Component;
        }


        public static void DrawArea(IMapComponent component)
        {
            if (component == null)
            {
                return;
            }

            Console.WriteLine("Drawing ...");
            component.Draw(0, 0);
            Console.WriteLine("==============\n");
        }

        static void Main(string[] args)
        {
            IMapComponent city = BuildCity(MapComponentFactory.Instance);
            DrawArea(city);

            IMapComponent road = city.FindChild("Main Street");
            DrawArea(road);

            IMapComponent house = city.FindChild("City Park");
            DrawArea(house);

            Console.WriteLine($"Total trees instances : {MapComponentFactory.Instance.TotalTrees}");
            Console.WriteLine($"Total roads instances : {MapComponentFactory.Instance.TotalRoads}");

            Console.Read();
        }
    }
}
