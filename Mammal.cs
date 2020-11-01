using ConsoleApp1;
using System;

namespace prelim_exam
{
    public class Mammal : Animal, IName 
    {
        public Mammal (string animalName, int numberOfLegs) : base(animalName, numberOfLegs) { }


        public new string _class = "Mammalia";

        public new string _ofType = "Mammal";

        public string fur { get; set; }
        public string sharpTongue { get; set; }

        public override string GetClass() => _class;

        public override string OfType() => _ofType;

    }


    public class Lion : Mammal, ILion
    {
        public Lion(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.fur = "Thick hair and has Mane";

            this. sharpTongue= "Papillae tongue";

            this.CanSwim = false;

            this.HasLegs();
        }
        
        public void Roar() => Console.WriteLine("Roar!");

    }


    public class Tiger : Mammal, ITiger
    {
        public Tiger(string animalName, int numberOfLegs) : base(animalName,numberOfLegs)
        {

            this.fur = "Thick hair";

            this.sharpTongue = "Papillae tongue";

            this.CanSwim = false;

            this.HasLegs();
        }
        public void Growl() => Console.WriteLine("Growl!");

    }

}
