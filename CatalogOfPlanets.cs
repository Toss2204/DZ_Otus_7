using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Otus_7
{
    public class CatalogOfPlanets
    {
        public string Name;
        

        public CatalogOfPlanets()
        {
            var Venus = new Planet("Venus", 2, 12100, planet: null);
            var Earth = new Planet("Earth", 3, 40075, Venus);
            var Mars = new Planet("Mars", 4, 21326, Earth);

            List<Planet> planets = new List<Planet>() { Venus, Earth, Mars };
        }


        


        public string GetPlanet(string name) 
        {
            return name;
        }

    }
}
