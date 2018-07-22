using System;
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

            CatcherService obService = new CatcherService(new CatcherA());
        }
    }

    public interface ICatcher
    {
        void Catch();
    }

    public class CatcherA : ICatcher
    {
        public void Catch()
        {
            Console.WriteLine("I AM Catcher A");
            Console.ReadLine();
        }
    }

    public class CatcherB : ICatcher
    {
        public void Catch()
        {
            Console.WriteLine("I AM Catcher B");
            Console.ReadLine();
        }
    }

    public class CatcherService
    {

        private ICatcher catcher;

        public CatcherService(ICatcher obj)
        {
            this.catcher = obj;
            catcher.Catch();
        }


    }
}
