using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameListIndexer.classes
{
    internal class menuClass
    {
        //----------------------------------------------------------------//
        public static void menuChoice()
        {
            bool run = true;
            NameListClass nameList = new NameListClass();

            while (run)
            {
                Console.WriteLine("1. Add shop name");
                Console.WriteLine("2. Display shop names");
                Console.WriteLine("3. Quit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            nameList.addShopName(nameList);
                            break;
                        case 2:
                            nameList.DisplayNames();
                            break;
                        case 3:
                            run = false;
                            break;
                        default:
                            Console.WriteLine("Please enter a valid option");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
        }
    }
}
