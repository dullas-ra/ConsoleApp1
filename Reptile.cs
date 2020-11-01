using ConsoleApp1;
using System;

namespace prelim_exam
{
    public class Reptile : Animal, IName
    {
        public Reptile(string animalName, int numberOfLegs) : base(animalName, numberOfLegs) { }


        public new string _class = "Reptilia";

        public new string _ofType = "Reptile";

        public string scales { get; set; }
        public string hood { get; set; }
        public string pattern { get; set; }
        public string claw { get; set; }

        public override string GetClass() => _class;
        public override string OfType() => _ofType;



    }

    public class Cobra : Reptile, ISnake
    {
        public Cobra(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.scales = "smooth scales";

            this.hood = "mane hood";

            this.pattern = "dull scale";

            this.CanSwim = true;

            this.HasLegs();

        }
        public void Hiss() => Console.WriteLine("Hiss!");
        public void Hood() => Console.WriteLine("Hooding");
    }

    public class Iguana : Reptile, IIguana
    {
        public Iguana(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.claw = "long claws";

            this.scales = "rough scales";

            this.CanSwim = false;

            this.HasLegs();
        }

        public void Crawl() => Console.WriteLine("Crawling");
        public void Sneeze() => Console.WriteLine("Sneeze!");
    }
}
