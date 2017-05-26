using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanNameSpaces
{

    namespace organy
    {
        public class Organy
        {
            public string name { get; set; }
            public double ves { get; set; }

            public string Cut()
            {
                return name;
            }
        }
    }

    class Human
    {
        private string name { get; set; }
        private int age;
        private double salary;

        public int stage { get; set; }

        public string GetName()
        {
            return name;
        }
    }
}
