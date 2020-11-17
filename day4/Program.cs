using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Motorcycle myMoto = new Motorcycle();
            //myMoto.Make = "Suzuki";
            //myMoto.Engine = new Engine();
            //myMoto.Engine.Volume = 650;
            //myMoto.Engine.EngineType = EngineType.Vtype;
            //myMoto.KilometersPassed = 10;
            //myMoto.LookAtMoto();
            //AddOneKm(myMoto);
            //myMoto.LookAtMoto();

            //var x = 10;
            //AddOne(x);
            //Console.WriteLine(x);

            Shkaf shkaf1 = new Shkaf();
            shkaf1.hight = 200;
            shkaf1.width = 250;
            shkaf1.depth = 150;
            shkaf1.opening = false;
            shkaf1.drop = new string[] { "Джинсы","Рубашка","Носки","ХУИ","ДИЛДО" };
            shkaf1.drop1.AddRange(shkaf1.drop);
            shkaf1.start();
            //shkaf1.LookAtShkaf();
            //shkaf1.question();
            //shkaf1.LookAtShkaf();


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
