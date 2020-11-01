using ConsoleApp1;

namespace prelim_exam
{
    public abstract class Animal : IName
    {
        //TODO: Modify this class so that we can set _class ONLY ONCE 
        public string _class;

        //TODO: Modify this class so that we can set _ofType ONLY ONCE
        //_ofType sample: Bird, Fish, Mammal -- all these classes are already provided
        public string _ofType;

        //TODO: Modify so that we can set number of legs ONLY ONCE
        //TODO: Must expose the value of _numberOfLegs but not the variable OUTSIDE the class
        int _numberOfLegs;

        public Animal(string animalName, int numberOfLegs)
        {
            _animalName = animalName;
            _numberOfLegs = numberOfLegs;
        }

        //Note: This is a auto-implemented getter-setter
        public bool CanSwim { get; set; }
        public string _animalName { get; set; }

        public abstract string GetClass();
        public abstract string OfType();
        public bool HasLegs() => _numberOfLegs > 0;

        public string IPrintAnimalName() => _animalName;




    }
}
