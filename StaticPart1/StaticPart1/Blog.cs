using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StaticPart1
{ using Helpers;
     class Blog
    { 
        static  void Metro()
        {
            Helper alfa = new Helper();
            
            Console.WriteLine(alfa.GetAge());

        }

    }
}
