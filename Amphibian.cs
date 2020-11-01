using System;
using ConsoleApp1;

namespace prelim_exam
{
    public class Amphibian : Animal, IName
    {

        public Amphibian(string animalName, int numberOfLegs) : base(animalName, numberOfLegs) { }


        public new string _class = "Amphibia";

        public new string _ofType = "Amphibian";


        public string legs { get; set; }
        public string toes { get; set; }
        public string skin { get; set; }


        public override string GetClass() => _class;
        public override string OfType() => _ofType;



    }


    public class Toad : Amphibian, IAmphibians
    {
        public Toad(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.legs = "shorter-length legs";

            this.toes = "webbed feet";

            this.skin = "rough skin";

            this.CanSwim = true;

            this.HasLegs();

        }

        public void Leaps() => Console.WriteLine("Hop!");
        public void Ribbet() => Console.WriteLine("Ribbet!");

    }
    public class Frog : Amphibian, IAmphibians
    {
        public Frog(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.legs = "long legs";

            this.toes = "webbed feet";

            this.skin = "smooth skin";

            this.CanSwim = true;

            this.HasLegs();

        }
        public void Leaps() => Console.WriteLine("Hop!");
        public void Ribbet() => Console.WriteLine("Ribbet!");


        
    }

}

