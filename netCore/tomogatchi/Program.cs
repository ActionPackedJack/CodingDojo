using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace tomogatchi
{
    public class tomogatchi
    {
        public int happiness;
        public int fullness;
        public int meals;
        public int energy;
        public string eat()
        {
            if(meals<1)
            {
                return("There is nothing to eat.");
            }
            this.meals--;
            Random rand = new Random();
            int result = rand.Next(1,4);
            if (result == 1)
            {
                return("Your meal was refused. Meals -1");
            }
            else
            {
                int gains=rand.Next(5,10);
                this.fullness += gains;
                return("Yum! Fullness +" +gains.ToString() + ", Meals -1.");
            }
        }
        public string play()
        {
            this.energy-=5;
            Random rand = new Random();
            int result = rand.Next(1,4);
            if (result == 1)
            {
                return("Your Tamagatchi doesn't want to play. Energy -5");
            }
            int gains = rand.Next(5,10);
            this.happiness+=gains;
            return("You played with your Tamagatchi!  Energy -5, Happiness +" + gains.ToString());
        }
        public string work()
        {
            this.energy -=5;
            Random rand = new Random();
            int gains = rand.Next(1,3);
            this.meals += gains;
            return("You get a good day's work in.  Energy -5, Meals " + gains.ToString());
        }
        public string sleep()
        {
            this.energy +=15;
            this.fullness -=5;
            this.happiness -=5;
            return("Your Tamagatchi sleeps peacefully.  Energy +15, Fullness -5, Happiness -5");
        }


    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
