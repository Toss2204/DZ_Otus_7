using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_Otus_7
{
    public class Planet
    {
        public string Name { get; set; }
        public int NumFromSun { get; set; }
        public int LengthEcuator { get; set; }
        public Planet PreviousPlanet { get; set; }

        public Planet(string name,int num, int length, Planet planet )
        {
            Name=name;
            NumFromSun=num;
            LengthEcuator=length;
            PreviousPlanet=planet;
        }

    }
}
