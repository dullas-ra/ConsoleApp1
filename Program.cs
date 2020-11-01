using System;
using System.Collections.Generic;
using ConsoleApp1;

namespace prelim_exam
{
    class Program
    {
        static void Main(string[] args)
        {

            Mammal Somali = new Lion("Simba", 4);

            Mammal Bengal = new Tiger("Ryker", 4);


            Reptile Rinkhals = new Cobra("Kenin", 0);

            Reptile Conopolous = new Iguana("Iggy", 4);


            Amphibian Natterjack = new Toad("Grogi", 4);

            Amphibian Xenopus = new Frog("Sophi", 4);


            Fish Redeye = new Piranha("Mooey", 0);

            Fish Conger = new Eel("Ciz", 0);


            Bird Dalmatian = new Pelican("Dorky", 2);

            Bird Rufous = new Hummingbird("Tweeky", 2);



             List<object> animal_Name = new List<object>
             {
                 Somali.IPrintAnimalName(),

                 Bengal.IPrintAnimalName(),

                 Rinkhals.IPrintAnimalName(),

                 Conopolous.IPrintAnimalName(),

                 Natterjack.IPrintAnimalName(),

                 Xenopus.IPrintAnimalName(),

                 Redeye.IPrintAnimalName(),

                 Conger.IPrintAnimalName(),

                 Dalmatian.IPrintAnimalName(),

                 Rufous.IPrintAnimalName()

             };


            for (int i=0; i < animal_Name.Count; i++)
            {
                Console.WriteLine(animal_Name[i]);
            }


        }
    }
}
