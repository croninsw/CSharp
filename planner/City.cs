using System;
using System.Collections.Generic;

namespace Planner
{
    public class City
    {
        // CLASSES
        // private
        private string _city { get; set; }

        private string _mayor { get; set; }

        private DateTime _dateFounded { get; set; }

        // public
        public List<Building> Buildings = new List<Building>();

        // methods
        public void Found() {
            _dateFounded = DateTime.Now;
        }
        public void AddBuilding(Building building) {
            Buildings.Add(building);
        }
        // constructor
        public City(string mayor)
        {
            _mayor = mayor;
        }
    }
}

// Name of the city.
// The mayor of the city.
// Year the city was established.
// A collection of all of the buildings in the city.
// A method to add a building to the city.