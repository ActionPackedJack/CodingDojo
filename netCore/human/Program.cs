using System;

namespace human
{
    public class Human
    {
        public string name;
        public int health = 100;
        public int strength = 3;
        public int dexterity = 3;
        public int intelligence = 3;
        public Human(string name = "none of your business")
        {
            this.name = name;
            System.Console.WriteLine("This human's name is " + this.name);
        }
        public Human(string name ="none of your business", int health=100, int dexterity=3, int intelligence = 3, int strength = 3)
        {
            this.name=name;
            this.health=health;
            this.dexterity=dexterity;
            this.intelligence=intelligence;
            this.strength=strength;

        }
        public void Attack(Human victim)
        {
            victim.health -= (this.strength * 5);
            System.Console.WriteLine("Oh no! "+victim.name + " has been injured and only has " + victim.health.ToString() + " health remaining!");
        }
    public class Ninja : Human
    {
        public void Steal(Human victim)
        {
            this.Attack(victim);
            this.health += 10;
            System.Console.WriteLine(this.name + " finds some medicinal herbs among the victim's belongings and consumes them, bringing the victorious shadow operative to " + this.health.ToString() + " health.");
        }
        public Ninja(string name="an unknown shadow") : base("an unknown shadow", 100, 175, 3, 3)
        {
        }
    }
    public class Wizard: Human
    {
        public void heal()
        {
            this.health += (this.intelligence * 10);
            System.Console.WriteLine(this.name + " casts a mending spell and restores themselves to " + this.health.ToString() + " health.");
        }
        public void fireball(Human victim)
        {
            Random rand = new Random();
            victim.health -= rand.Next(20,50);
            System.Console.WriteLine(this.name + " unleashes a mighty fireball, searing the flesh of " + victim.name + "! The target's health is reduced to " + victim.health.ToString() + "!");
        }
        public Wizard(string name="a mysterious robed figure") : base("a mysterious robed figure", 50, 3, 25, 3)
        {
        }

    }
        class Program
        {
            static void Main(string[] args)
            {
                Human Roger = new Human("Roger", 3, 5, 7, 9);
                Human Mystery = new Human("Blomp");
                Roger.Attack(Mystery);
                Ninja Rikimaru = new Ninja("Rikimaru");
                System.Console.WriteLine(Rikimaru.strength);
                Rikimaru.Steal(Roger);
                Wizard Barnabus = new Wizard("Barnabus");
                Barnabus.heal();
                Barnabus.fireball(Rikimaru);
            }
        }

    }
}
