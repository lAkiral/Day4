using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorcycle myMoto = new Motorcycle();
            myMoto.Make = "Suzuki";
            myMoto.Engine = new Engine();
            myMoto.Engine.Volume = 650;
            myMoto.Engine.EngineType = EngineType.Vtype;
            myMoto.KilometersPassed = 10;
            myMoto.LookAtMoto();
            AddOneKm(myMoto);
            myMoto.LookAtMoto();

            //var x = 10;
            //AddOne(x);
            //Console.WriteLine(x);
        }

        static void AddOne(int x)
        {
            x = x + 1;
            Console.WriteLine(x);
        }

        static void AddOneKm(Motorcycle moto)
        {
            moto.KilometersPassed = moto.KilometersPassed + 1;
            moto.Make = "Broken Moto";

        }
    }
}
