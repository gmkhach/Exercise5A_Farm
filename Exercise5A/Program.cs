using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requirement #1 - Create a farm.
            Farm myFarm = new Farm();

            for(int i = 0; i < myFarm.GetAnimals().Count(); i++)
            {
                if (myFarm.GetAnimals()[i].GetType() == typeof(Cow))
                {
                    Cow myCow = (Cow)myFarm.GetAnimals()[i];
                    myCow.Speak();
                }
                else if (myFarm.GetAnimals()[i].GetType() == typeof(Horse))
                {
                    Horse myCow = (Horse)myFarm.GetAnimals()[i];
                    myCow.Speak();
                }
                else if (myFarm.GetAnimals()[i].GetType() == typeof(Sheep))
                {
                    Sheep myCow = (Sheep)myFarm.GetAnimals()[i];
                    myCow.Speak();
                }
                else if (myFarm.GetAnimals()[i].GetType() == typeof(Duck))
                {
                    Duck myCow = (Duck)myFarm.GetAnimals()[i];
                    myCow.Speak();
                }
            }
        }

    }
}
