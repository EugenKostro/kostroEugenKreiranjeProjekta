using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kostroEugenKreiranjeProjekta
{
    class Program
    {
        static void Main(string[] args)
        {


            float y = 50.45F;
            int x = Convert.ToInt32(y);

            Console.WriteLine("y = " + y + " eura");

            Console.WriteLine("x = {0} rublji. A y = {1} ", x, y);




            Console.ReadKey();

        }
    }
}