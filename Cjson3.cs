using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web.Script.Serialization;
using Newtonsoft.Json;

namespace JSON
{
    class Item : IEquatable<Item>
    {
        public string Name;
        public int Price;
        public Item(string i,int j=0)
        {
            this.Name = i;
            this.Price = j;
        }
        public bool Equals(Item otheres)
        {
            if (otheres == null)
                return false;
            return (this.Name.Equals(otheres.Name));
        }
    }
    class Cjson3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Data Json");
            string js = File.ReadAllText(@"Json3.json");
            List<Item> myList = JsonConvert.DeserializeObject<List<Item>>(js);
            if (myList == null)
                myList = new List<Item>();

            string input = "";
            int inputint = 0;
            string inputstring = "";

            while(input !="Exit")
            {
                Console.WriteLine("Enter 'A' to ADD new Items");
                Console.WriteLine("Enter 'D' to Delete new Items");
                Console.WriteLine("Enter 'S' to Show new Items");
                Console.WriteLine("Enter 'Q' to Quit new Items");
                input = Console.ReadLine();
                switch(input)
                {
                    case "A":
                        Console.WriteLine("Adding new Iteam");
                        Console.WriteLine("Enter Item Name");
                        inputstring = Console.ReadLine();
                        Console.WriteLine("Enter Item Price");
                        inputint = Convert.ToInt32(Console.ReadLine());
                        myList.Add(new Item(inputstring, inputint));
                        Console.WriteLine("Added Iteam " + inputstring + " with price " + inputint);
                        break;
                    case "D":
                        Console.WriteLine("Delete Iteam");
                        Console.WriteLine("Enter Item Name to delete");
                        inputstring = Console.ReadLine();               
                        myList.Remove(new Item(inputstring));
                        Console.WriteLine("Removed Iteam " + inputstring);
                        break;
                    case "Q":
                        Console.WriteLine("Quit Program");
                        break;
                    case "S":
                        Console.WriteLine("\nShowing Content :");
                        foreach(Item item in myList)
                        {
                            Console.WriteLine("Item : " + item.Name + " | $ " + item.Price);
                        }
                        Console.WriteLine("\n");
                        break;
                }
            }
            Console.WriteLine("Retriving data from JSON");
            string data = JsonConvert.SerializeObject(myList);
            File.WriteAllText(@"Json3.json", data);
            Console.ReadLine();
        }
    }
}
