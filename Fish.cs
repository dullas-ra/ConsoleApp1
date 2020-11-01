using ConsoleApp1;

namespace prelim_exam
{
    public class Fish : Animal, IName
    {
        public Fish(string animalName, int numberOfLegs) : base(animalName, numberOfLegs) { }


        public new string _class = "Anatidae";

        public new string _ofType = "Fishes";

        public string teeth { get; set; }
        public string fins { get; set; }
        public string fishType { get; set; }
        public string skin { get; set; }

        public override string GetClass() => _class;
        public override string OfType() => _ofType;


    }


    public class Piranha : Fish, IFish
    {
        public Piranha(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.teeth = "razer sharp teeth";

            this.CanSwim = true;

            this.HasLegs();

        }

        public void Swim(string swimType) => swimType = "swims to its fromt";

    }

    public class Eel : Fish, IFish
    {
        public Eel(string animalName, int numberOfLegs) : base(animalName, numberOfLegs)
        {

            this.fishType = "electric snake type";

            this.fins = "soft-rayed fins";

            this.skin = "slippery skin";

            this.CanSwim = true;

            this.HasLegs();

        }
        public void Swim(string swimType) => swimType = "swim backwards";

    }
}
