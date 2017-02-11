using System;

namespace _02_Flyweight_Map
{
    // In this example we use flyweights like components of composite

    // FlyweightFactory is responsible for creating/caching components(flyweights) and
    // use LazyConcurrentDictionary under the hood for storing them

    // For building composite we use builders 
    // RoadBuilder(HighwayBuilder) is used for build 'road' element which consists 'MapRoadFlyweight'
    // flyweight components of composite
    // SquareBuilder(ParkBuilder) is used for build 'park' element which consists 'MapTreeFlyweight'
    // flyweight components of composite
    // BuildingBuilder(HouseBuilder) is used for build 'houses' element from 'MapHouseFlyweight'
    // flyweight components of composite
    // DistrictBuilder(SmallDistrictBuilder) is used for build 'district' which consists houses, parks and roads
    // CityBuilder(SmallCityBuilder) is used for build 'city' which consists of districts


    internal class Program
    {
        public static IMapComponent BuildCity(FlyweightComponentFactory factory)
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

        private static void Main()
        {
            IMapComponent city = BuildCity(FlyweightComponentFactory.Instance);
            DrawArea(city);

            IMapComponent road = city.FindChild("Main Street");
            DrawArea(road);

            IMapComponent house = city.FindChild("City Park");
            DrawArea(house);

            Console.WriteLine($"Total trees instances : {FlyweightComponentFactory.Instance.TotalTrees}");
            Console.WriteLine($"Total roads instances : {FlyweightComponentFactory.Instance.TotalRoads}");

            Console.Read();
        }
    }
}
