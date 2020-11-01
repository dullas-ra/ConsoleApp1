using ConsoleApp1;
using System;

namespace prelim_exam
{
    public class Bird : Animal, IName
    {
        public Bird(string animalName, int numberOfLegs) : base(animalName, numberOfLegs) { }


        public new string _class = "Aves";

        public new string _ofType = "Birds";

        public string beak { get; set; }
        public string skin { get; set; }

        public override string GetClass() => _class;
        public override string OfType() => _ofType;

 
    }

    public class Pelican : Bird, IBird
    {
        public Pelican(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.beak = "long beak";

            this.skin = "pouch on its front";

            this.CanSwim = false;

            this.HasLegs();
        }

        public void Fly() => Console.WriteLine("Fly!");
    }
    public class Hummingbird : Bird, IBird
    {
        public Hummingbird(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.beak = "long beak";

            this.skin = "pouch on its front";

            this.CanSwim = false;

            this.HasLegs();
        }

        public void Fly() => Console.WriteLine("Fly!");

    }
}
