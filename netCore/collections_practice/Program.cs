using System;
    using System.Collections.Generic;

namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]numArray={ 
                0,
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9
            };
            string[]nameArray={
                "Tim",
                "Martin",
                "Nikki",
                "Sara"
            };
            bool[]boolArray={
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
                true,
                false,
            };
            Console.WriteLine(numArray);
            Console.WriteLine(nameArray);
            Console.WriteLine(boolArray);
            int[,]tableArray= new int[10,10];
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    tableArray[i,j]= (i+1)*(j+1);   
                }
            }
            foreach(int table in tableArray){
                Console.WriteLine(table);
            }
            List<string> flavors = new List<string>();
            flavors.Add("Cherry Plumps");
            flavors.Add("Dirt Road");
            flavors.Add("Bloody Sundae");
            flavors.Add("Bertram's Beeswax");
            flavors.Add("Hefeweizen");
            Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[2]);
            flavors.RemoveAt(2);
            Console.WriteLine(flavors.Count);
            Dictionary<string,string> favorites = new Dictionary<string,string>();
            foreach(string name in nameArray)
            {
                favorites.Add(name, null);
            }
            Random rand = new Random();
            // foreach(var name in favorites)
            // {
            //     string faveflav=flavors[rand.Next(0, flavors.Count)];
            //     var newEntry= (name, faveflav);
            //     favorites[name.Key] = faveflav;
            // }
            List<string> keys = new List<string>(favorites.Keys);
            foreach(var key in keys)
            {
               string faveflav=flavors[rand.Next(0, flavors.Count)];
               favorites[key] = faveflav; 
            }
            foreach(var person in favorites)
            {
                System.Console.WriteLine(person.Key + "'s favorite flavor is "+ person.Value);
            }
        }
    }
}
