using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SkechersCode
{   class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> dictItem = new Dictionary<string, string>();
            string msg = string.Empty;
            string val = string.Empty;


            // apple
            Items apple = new Items("Apple");
            apple.color = "red";
            apple.stem = true;
            apple.taste = "sweet";
            msg = apple.ToString();
            val = apple.Value;
            dictItem.Add(val, msg);

            // cow
            Items cow = new Items("Cow");
            cow.color = "brown";
            cow.stem = false;
            cow.taste = "umami";
            cow.legs = "4";
            cow.bark = false;
            msg = cow.ToString();
            val = cow.Value;
            dictItem.Add(val, msg);

            // tree
            Items tree = new Items("Tree");
            tree.color = "brown";
            tree.root = true;
            tree.leaves = "32767";
            tree.legs = "4";
            tree.bark = true;
            msg = tree.ToString();
            val = tree.Value;
            dictItem.Add(val, msg);


            // dog
            Items dog = new Items("Dog");
            dog.color = "brown";
            dog.apendage = "4";
            dog.bark = true;
            msg = dog.ToString();
            val = dog.Value;
            dictItem.Add(val, msg);


            var list = dictItem.Keys.ToList();
            list.Sort();

            // Loop through keys.
            foreach (var key in list)
            {
                Console.WriteLine("{1}", key, dictItem[key]);
            }
            Console.Read();
        }
         
    }
}
