using System;
using System.Collections.Generic;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Building> buildings = new List<Building>();
            Building FiveOneTwoEigth = new Building("512 8th Avenue")
            {
                Width = 1_000,
                Depth = 3_000,
                Stories = 8
            };
            Building FiveOneTwoTen = new Building("512 10th Avenue")
            {
                Width = 2_000,
                Depth = 6_000,
                Stories = 12
            };
            Building FiveOneTwoSeven = new Building("512 7th Avenue")
            {
                Width = 900,
                Depth = 1000,
                Stories = 4
            };

            FiveOneTwoEigth.Construct();
            FiveOneTwoSeven.Construct();
            FiveOneTwoTen.Construct();
            FiveOneTwoEigth.Purchase("NSS School");
            FiveOneTwoSeven.Purchase("HCA Healtcare");
            FiveOneTwoTen.Purchase("Disney Enterprice");

            City megalopolis = new City("Nashville", "Jim Shulman", 1799);
            megalopolis.ListOfBuildings.Add(FiveOneTwoSeven);
            megalopolis.ListOfBuildings.Add(FiveOneTwoTen);
            megalopolis.ListOfBuildings.Add(FiveOneTwoEigth);

            foreach (Building building in megalopolis.ListOfBuildings)
            {
                Console.WriteLine(building.Description);
            }

        }
    }
}