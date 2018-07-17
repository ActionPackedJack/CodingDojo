using System;


namespace Dojodachi.Models
{
    public class Dachi
    {
        public static Random random= new Random();
        public int energy{set;get;}
        public int fullness{set;get;}
        public int happiness{set;get;}
        public int meals{set;get;}
        public string result{set;get;}
        public bool alive;
    
    public Dachi()
    {
        this.energy = 50;
        this.happiness = 20;
        this.fullness = 20;
        this.meals = 3;
        this.alive=true;
        this.result="It's just another lazy day in your manor. You sit absent-mindedly on the rocking chair on your front porch, sipping a cocktail and reading classic literature. You've always been intrigued by ancient arts, but the finer points of symbolism are lost on you. This is just another way you've decided to fill the time since the accident took your family. But it seems books, much like everything else, are unable to fill the hole left behind in their absence. But suddenly you hear a faint noise coming from the bushes. You sit in silence for a few minutes, at first frozen with fear, but gradually this fear gives way to morbid curiosity.  The noise was unlike anything you've ever heard before.  Simultaneously it was abrasive, vicious, and venomous, but also adorable, inviting and relaxing. Finally, your body seems to lift itself and head in the direction of the sound's origin. Peeling aside a shrub, you see a small creature unlike any you've ever seen before. Like its cries, it is simultaneously hideous and endearing. You pick it up, and it immediately squeals softly and nuzzles into your arms like a blanket made of flesh. Looking upon it, you know you found this bizarre entity for a reason. Only you appreciate its true nature, and only it understands you. You take it into your basement and begin thinking out loud how best to nurture it.";
    }
    public void feed()
    {
        meals--;
        if(random.Next(0,4)== 0){
            result= "Your Dojodachi refuses to eat.  Meals -1";
            return;
        }
        fullness += random.Next(5,11);
        if(isWinner())
        {
            alive = false;
            return "A winner is you!";
        }
        result= "You fed your Dojodachi";
    }
    public void play()
    {
        energy -=5;
        if(random.Next(0,4)==0)
        {
            result= "Your Dojodachi finds you intensely boring.";
            return;
        }
        if(isWinner())
        {
            alive = false;
            result= "A winner is you!";
        }
        happiness += random.Next(5,11);
        result= "You played with your Dojodachi.";
    }
    public void work()
    {
        if(energy >=5)
        {
            energy -=5;
            meals += random.Next(1,4);
            result= "You put your Dojodachi to work.";
            return;
        }
        else
        {
            result= "Your Dojodachi is too tired to work";
        }
    }
    public void sleep()
    {
        energy+=15;
        happiness -=5;
        fullness -=5;
        if (happiness <=0 || fullness <=0)
        {
            alive=false;
            result= "Your Dojodachi has passed away...";
        }
        if(isWinner())
        {
            alive = false;
            result= "A winner is you!";
            return;
        }
        result= "Your Dojodachi sleeps.";
    }
    public bool isWinner()
    {
        if(fullness >= 100 && happiness >= 100 && energy >=100)
        {
            return true;
        }
        return false;
    }
    }
}