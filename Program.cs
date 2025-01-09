using System.Numerics;

namespace DZ_Otus_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Программа 1 


            Console.WriteLine("Первое задание");
            FirstTask();

            //Задание 2
            Console.WriteLine("Второе задание");
            SecondTask(); 
            
            //var catPlan = new CatalogOfPlanets();
            //Console.WriteLine(catPlan.GetPlanet("Земля"));
            //Console.WriteLine(catPlan.GetPlanet("Лимония"));
            //Console.WriteLine(catPlan.GetPlanet("Марс"));
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
        }

        public static void SecondTask()
        {
            var planets = new CatalogOfPlanets();
            Console.WriteLine(planets.GetPlanet("Земля"));
            Console.WriteLine(planets.GetPlanet("Лимония"));
            Console.WriteLine(planets.GetPlanet("Марс"));

        }
    }
    

}
