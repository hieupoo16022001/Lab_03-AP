using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class Program
    {
        static void Main()
        {
            Car myCar;
            System.Console.WriteLine("Creating a Car object and assing" + "its memory location to myCar");
            myCar = new Car();

            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "Black";
            myCar.yearBuilt = 1995;

            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model =" + myCar.model);
            System.Console.WriteLine("myCar.color =" + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt =" + myCar.yearBuilt);

            myCar.Start();
            myCar.Stop();

            System.Console.WriteLine("Creating another Car object and" + "assing its memory location to redPorche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxter";
            redPorsche.color = "Red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("redPorsche is a " + redPorsche.model);
            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make =" + myCar.make);
            System.Console.WriteLine("myCar.model =" + myCar.model);
            System.Console.WriteLine("myCar.color =" + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt =" + myCar.yearBuilt);

            myCar = null;
            Console.ReadLine();
        

        }
    }
}
