using System;

namespace day4
{
    public class Motorcycle
    {
        public Engine Engine { get; set; }

        public string Make { get; set; }

        public int KilometersPassed { get; set; }

        public void DriveALittle()
        {
            var random = new Random();
            KilometersPassed += random.Next(30, 200);
        }

        public void LookAtMoto()
        {
            Console.WriteLine($"Moto make: {Make}, Engine is {Engine.EngineType} of {Engine.Volume} CC volume, Passed {KilometersPassed}");
        }

    }
}
