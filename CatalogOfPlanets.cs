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
        public string namePlanet;
        public int counter;
        public List<Planet> planets;

        public CatalogOfPlanets()
        {
            var Venus = new Planet("Venus", 2, 12100, planet: null);
            var Earth = new Planet("Earth", 3, 40075, Venus);
            var Mars = new Planet("Mars", 4, 21326, Earth);

            planets = new List<Planet>() { Venus, Earth, Mars };
        }


        


        public (int, int, string) GetPlanet(string name) 
        {
            counter++;
            if (counter % 3 == 0)
            {
                return (0, 0, "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!");
            }
            else 
            {
                
                if (planets.Any(p => p.Name == name))
                {
                    var planetFound = planets.Find(p => p.Name == name);
                    if (planetFound != null)
                    {
                        return (planetFound.NumFromSun, planetFound.LengthEcuator, "");
                    }
                }
                
                return (0, 0, $"Найти планету с таким именем '{name}' не удалось");
                
                            
            }

        }

    }
}
