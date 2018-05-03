using System;
using System.Collections.Generic;
using System.Linq;
//using System.Object;
using JsonData;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Collections to work with
            List<Artist> Artists = JsonToFile<Artist>.ReadJson();
            List<Group> Groups = JsonToFile<Group>.ReadJson();

            //========================================================
            //Solve all of the prompts below using various LINQ queries
            //========================================================

            //There is only one artist in this collection from Mount Vernon, what is their name and age?
            var vernonite= Artists.Where(a => a.Hometown == "Mount Vernon").Select(a => new{a.ArtistName, a.Age});
            foreach(var artist in vernonite)
            {
                System.Console.WriteLine(artist.ArtistName + " is from Mount Vernon and is of age " + artist.Age);
            }
            //System.Console.WriteLine(vernonite); 
        

            //Who is the youngest artist in our collection of artists?
            var ages = from artist in Artists
                            orderby artist.Age ascending
                            select artist;
            var youngest= ages.Take(1);
            foreach (var artist in youngest)
            {
                System.Console.WriteLine(artist.ArtistName + " is the youngest artist.");
            }

            //Display all artists with 'William' somewhere in their real name
            var williams = Artists.Where(a => a.RealName.Contains("William"));
            System.Console.WriteLine("The following artists have William somewhere in their first or last name:");
            foreach( var artist in williams)
            {
                System.Console.WriteLine(artist.RealName);
            }
            //Display the 3 oldest artist from Atlanta
            System.Console.WriteLine("The three oldest artists from Atlanta are:");
            var atlantists= from artist in Artists
                            where artist.Hometown == "Atlanta"
                            orderby artist.Age descending
                            select artist;
            var eldest=atlantists.Take(3);
            foreach (var artist in eldest)
            {
                System.Console.WriteLine(artist.ArtistName);
            }

            //(Optional) Display the Group Name of all groups that have members that are not from New York City

            //(Optional) Display the artist names of all members of the group 'Wu-Tang Clan'
        }
    }
}
