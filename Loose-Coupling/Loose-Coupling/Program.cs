﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loose_Coupling
{
    class Program
    {
        static void Main(string[] args)
        {

            //CatcherService obService = new CatcherService(new CatcherA());
            ICatcher obj = new CatcherA();
            
            ICatcher obj2 = new CatcherB();
           
        }
    }

}
