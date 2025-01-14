using System.Diagnostics.Metrics;
using System.Numerics;
using System.Reflection;

namespace DZ_Otus_7
{
    internal class Program
    {

        //public delegate string PlanetValidator(string planetName);
        //public int counter;
        //public string PlanetValidatorMethod(string planetName)
        //{
        //    counter++;
        //    if (counter % 3 == 0)
        //    {
        //        return "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!";
        //    }
        //    return null;
        //}

        static void Main(string[] args)
        {
            //Программа 1 


            Console.WriteLine("Первое задание");
            FirstTask();

            //Задание 2
            Console.WriteLine("");
            Console.WriteLine("Второе задание");
            SecondTask();

            //Задание 3
            Console.WriteLine("Третье задание");
            ThirdTask();
        }


        public static void FirstTask()
        {

            var Venus = new
            {
                Name = "Venus",
                NumFromSun = 2,
                LengthEcuator = 12100,
                PreviousPlanet = (object)null
            };

            var Earth = new
            {

                Name = "Earth",
                NumFromSun = 3,
                LengthEcuator = 40075,
                PreviousPlanet = (object)Venus
            };

            var Mars = new
            {
                Name = "Mars",
                NumFromSun = 4,
                LengthEcuator = 21326,
                PreviousPlanet = Earth
            };

            var Venus2 = new
            {
                Name = "Venus",
                NumFromSun = 2,
                LengthEcuator = 12100,
                PreviousPlanet = Mars
            };


            //var Planets = new Array[] { Venus,Earth,Mars,Venus2};

            //foreach (var planet in Planets)
            //{
            //    Console.WriteLine($"Информация по планете {planet.Name}:");
            //    Console.WriteLine($"    Длина экватора: {planet}");
            //}

            Console.WriteLine($" Информация по планете {Venus.Name}:");
            Console.WriteLine($"    Длина экватора: {Venus.LengthEcuator} км");
            Console.WriteLine($"    Порядковый номер от Солнца: {Venus.NumFromSun}");
            Console.WriteLine($"    Эта планета эквивалентна Венере: {Venus.Equals(Venus)}");

            Console.WriteLine();

            Console.WriteLine($" Информация по планете {Earth.Name}:");
            Console.WriteLine($"    Длина экватора: {Earth.LengthEcuator} км");
            Console.WriteLine($"    Порядковый номер от Солнца: {Earth.NumFromSun}");
            Console.WriteLine($"    Эта планета эквивалентна Венере: {Earth.Equals(Venus)}");

            Console.WriteLine();

            Console.WriteLine($" Информация по планете {Mars.Name}:");
            Console.WriteLine($"    Длина экватора: {Mars.LengthEcuator} км");
            Console.WriteLine($"    Порядковый номер от Солнца: {Mars.NumFromSun}");
            Console.WriteLine($"    Эта планета эквивалентна Венере: {Mars.Equals(Venus)}");

            Console.WriteLine();

            Console.WriteLine($" Информация по планете {Venus2.Name}:");
            Console.WriteLine($"    Длина экватора: {Venus2.LengthEcuator} км");
            Console.WriteLine($"    Порядковый номер от Солнца: {Venus2.NumFromSun}");
            Console.WriteLine($"    Эта планета эквивалентна Венере: {Venus2.Equals(Venus)}");

            Console.WriteLine();
            Console.WriteLine(new string('-', Console.WindowWidth));
        }

        public static void SecondTask()
        {

            var planets = new CatalogOfPlanets();

            string[] arrayPlanets = ["Earth", "Лимония", "Mars"];

            foreach (var planet in arrayPlanets)
            {
                var tuple = planets.GetPlanet(planet);
                if (tuple.Item3.Length > 0) //значит не найдена планета или перебор с количеством запроса
                {
                    Console.WriteLine(tuple.Item3);
                }
                else
                {
                    Console.WriteLine(planet);
                    Console.WriteLine($"Порядковый номер от Солнца: {tuple.Item1}");
                    Console.WriteLine($"Длина экватора: {tuple.Item2} км");
                }

                Console.WriteLine();
            }
            Console.WriteLine(new string('-', Console.WindowWidth));

        }

        public static void ThirdTask()
        {
           int counter=0;
        var planets = new CatalogOfPlanets_new();

        string[] arrayPlanets = ["Earth", "Лимония", "Mars","Юпитер","Меркурий","Сатурн"];
            
            foreach (var planet in arrayPlanets)
            {
                var tuple = planets.GetPlanet(planet,planet=> {
                    counter++;
                    if (counter % 3 == 0)
                    {
                        return "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!";
                    }
                    return null;
                });

                if (tuple.Item3.Length > 0) //значит не найдена планета или перебор с количеством запроса
                {
                    Console.WriteLine(tuple.Item3);
                }
                else
                {
                    Console.WriteLine(planet);
                    Console.WriteLine($"Порядковый номер от Солнца: {tuple.Item1}");
                    Console.WriteLine($"Длина экватора: {tuple.Item2} км");
                }

                Console.WriteLine();
            }

            Console.WriteLine(new string ('-',Console.WindowWidth));

            foreach (var planet in arrayPlanets)
            {
                var tuple = planets.GetPlanet(planet, planet=> {
                    counter++;
                    if (counter % 3 == 0)
                    {
                        return "Оставь меня, старушка, я в печали... Слишком часто запрашиваете!";
                    }

                    if (planet.ToLower() == "лимония")
                    {
                        return "Запретная планета";
                    }
                    return null;
                });
            
                if (tuple.Item3.Length > 0) //значит не найдена планета или перебор с количеством запроса
                {
                    Console.WriteLine(tuple.Item3);
                }
                else
                {
                    Console.WriteLine(planet);
                    Console.WriteLine($"Порядковый номер от Солнца: {tuple.Item1}");
                    Console.WriteLine($"Длина экватора: {tuple.Item2} км");
                }

                Console.WriteLine();
            }


        }
            


        }
    }
    



