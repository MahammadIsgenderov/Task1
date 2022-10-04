using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticPart1.Helpers
{
     class Helper
    {
        public string Name;
        public string Surname;
        private int Age;

        public void SetAge(int age)
        {
          

            if(Age>=10 && Age<=40)
            {
                Console.WriteLine("hele Cavansan");
                return;
            }
            Console.WriteLine("duz daxil edin yasi daynaa");

        }
        public int GetAge()
        {
            return Age;
        }
    }
}
