using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static NameListIndexer.classes.shopName;
//********************************************START OF FILE**********************************//
namespace NameListIndexer.classes
{
    /// <summary>
    /// Name: Luke Michael Carolus
    /// StudentID: ST10254164
    /// Module: PROG6212
    /// </summary>
    /// 

    internal class NameListClass : IEnumerable<KeyValuePair<string, ShopName>>
    {
        private Dictionary<string, ShopName> listShop = new Dictionary<string, ShopName>();
        //----------------------------------------------------------------//
        public void addShopName(NameListClass nameList)
        {
            Console.Write("Enter shop name: ");
            string name = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(name))
            {
                nameList[name] = new ShopName(name);
                Console.WriteLine($"{name} added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid shop name. Please try again.");
            }
        }

        //----------------------------------------------------------------//

            public ShopName this[string name]
            {
                get => listShop[name];
                set => listShop[name] = value;
            }

            public void Clear() => listShop.Clear();
            public int Count => listShop.Count;

            public IEnumerator<KeyValuePair<string, ShopName>> GetEnumerator() => listShop.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public void DisplayNames()
            {
                Console.WriteLine("Shop names in the list:");
                int index = 0;
                foreach (var shop in listShop)
                {
                    Console.WriteLine($"Index {index} = {shop.Value.Name}");
                    index++;
                }
            }
            //create a method that displays the names in the order they were added

            //----------------------------------------------------------------//
        }
    }
//*************************************END OF FILE***********************************************//