using System;
using Trestlebridge.Interfaces;
using Trestlebridge.Models;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Actions
{
    public class PurchaseStock
    {
        public static void CollectInput(Farm farm)
        {
            Console.WriteLine("1. Cow");
            Console.WriteLine("2. Ostrich");
            Console.WriteLine("3. Goat");
            Console.WriteLine("4. Pig");
            Console.WriteLine("5. Sheep");
            Console.WriteLine("6. Chicken");
            Console.WriteLine("7. Duck");

            Console.WriteLine();
            Console.WriteLine("What are you buying today?");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (Int32.Parse(choice))
            {
                case 1:
                    ChooseGrazingField.CollectInput(farm, new Cow());
                    break;

                case 2:
                    ChooseGrazingField.CollectInput(farm, new Ostrich());
                    break;

                case 3:
                    ChooseGrazingField.CollectInput(farm, new Goat());
                    break;

                case 4:
                    ChooseGrazingField.CollectInput(farm, new Pig());
                    break;
                    ;
                case 5:
                    ChooseGrazingField.CollectInput(farm, new Sheep());
                    break;
                case 6:
                    ChooseChickenHouse.CollectInput(farm, new Chicken());
                    break;
                case 7:
                    ChooseDuckHouse.CollectInput(farm, new Duck());
                    break;
            }
        }
    }
}