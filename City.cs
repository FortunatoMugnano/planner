using System;
using System.Collections.Generic;

namespace Planner
{
    class City
    {
        public string Name { get; }
        public string Mayor { get; }
        public int Established { get; }
        public List<Building> ListOfBuildings { get; set; }

        public City(string name, string mayor, int established)
        {
            Name = name;
            Mayor = mayor;
            Established = established;
            ListOfBuildings = new List<Building>();
        }

    }
}