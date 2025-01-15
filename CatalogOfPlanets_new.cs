using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Otus_7
{
    public class CatalogOfPlanets_new
    {
        public string namePlanet;
        public int counter;
        public List<Planet> planets;

        public delegate string PlanetValidator(string planetName);

        //public string PlanetValidatorMethod(string planetName)
        //{
        //    counter++;
        //    if (counter % 3 == 0)
        //    {
        //        return "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!";
        //    }
        //    return null;
        //}

        //public string PlanetValidatorMethod_Limon(string planetName)
        //{
        //    counter++;
        //    if (counter % 3 == 0)
        //    {
        //        return "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!";
        //    }

        //    if (planetName.ToLower() == "лимония")
        //    {
        //        return "Запретная планета";
        //    }
        //    return null;
        //}

        public CatalogOfPlanets_new()
        {
            var Venus = new Planet("Venus", 2, 12100, planet: null);
            var Earth = new Planet("Earth", 3, 40075, Venus);
            var Mars = new Planet("Mars", 4, 21326, Earth);

            planets = new List<Planet>() { Venus, Earth, Mars };
        }





        public (int, int, string) GetPlanet(string name, PlanetValidator validator) 
        {
            //validator = PlanetValidatorMethod;
            string validator_val = validator(name);

            if (validator_val == null)  
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
            else
            {
                return (0, 0, validator_val);
            }
        }

    }
}
