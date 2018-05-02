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
        class Program
        {
            static void Main(string[] args)
            {
                Human Roger = new Human("Roger", 3, 5, 7, 9);
                Human Mystery = new Human("Blomp");
                Roger.Attack(Mystery);
            }
        }

    }
}
