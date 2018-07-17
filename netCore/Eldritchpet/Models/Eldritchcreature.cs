using System;
using System.Collections.Generic;
using System.Web;


namespace Eldritchpet.Models
{
    public class Eldritchcreature
    {
        public static Random random= new Random();
        public int energy{set;get;}
        public int fullness{set;get;}
        public int happiness{set;get;}
        public int meals{set;get;}
        public string result{set;get;}
        public bool alive;
        public bool hasevolved;
		public List<string> nightmares {get;set;}
    
    public Eldritchcreature()
    {
        this.energy = 50;
        this.happiness = 20;
        this.fullness = 20;
        this.meals = 3;
        this.alive=true;
        this.hasevolved=false;
        this.result="It's just another lazy day in your manor. You sit absent-mindedly on the rocking chair on your front porch, sipping a cocktail and reading classic literature. You've always been intrigued by ancient arts, but the finer points of symbolism are lost on you. This is just another way you've decided to fill the time since the accident took your family. But it seems books, much like everything else, are unable to fill the hole left behind in their absence. Suddenly, you hear a faint noise coming from the bushes. You sit in silence for a few minutes, at first frozen with fear, but gradually this fear gives way to morbid curiosity.  The noise was unlike anything you've ever heard before.  Simultaneously it was abrasive, vicious, and venomous, but also adorable, inviting and relaxing. Finally, your body seems to lift itself and head in the direction of the sound's origin. Peeling aside a shrub, you see a small creature unlike any you've ever seen before. Like its cries, its form is simultaneously hideous and endearing. You pick it up, and it immediately squeals softly and nuzzles into your arms like a blanket made of flesh. Looking upon it, you know you found this bizarre entity for a reason. Only you appreciate its true nature, and only it understands you. You take it into your basement and begin thinking out loud how best to nurture it.";

    }
    public object feed()
    {
        meals--;
		string[] meal = new[]{"bounty", "sacrifice", "offering", "tribute", "donation", "pittance", "gift"};
        if(random.Next(0,4)== 0){
			string[] emotion = new[]{"listlessly", "disinterestedly", "apathetically", "inquisitively", "nonchalantly"};
			string[] bodypart = new[]{"flagellum", "tentacle","foot","paw","prehensile tail","telekinesis","proboscis"};
            result= "The creature " + emotion[random.Next(0,emotion.Length)] + " pushes your " + meal[random.Next(0,meal.Length)] + " around on the floor with its " + bodypart[random.Next(0,bodypart.Length)] + " but neglects to consume it.  Meals -1";
            return this;
        }
        fullness += random.Next(5,11);
        if(Evolves())
        {
            return new Eldritchabomination(energy, happiness, fullness+(5*meals), 0, true, true, "The creature has grown quite large and gobbles up your remaining food supplies.  You will need to find larger sources of food...");
        }

        if(isWinner())
        {
            alive = false;
            result= "The creature devours the rest of your food, and then washes it down by consuming your refrigerator in a single bite. It has grown quite large. You ponder what your pet should eat next, but it seems to have already made up its mind as it slowly approaches you with its mouth open. And suddenly your destiny becomes clear. You kneel on the floor of your basement, your eyes closed, your arms stretched to the side, your head titled back, ready to become a part of something greater than yourself. As the beast's jaws close around you, you feel no pain, only a sense of belonging. For the first time in your life, you are home.";
			return this;
        }
		string[] hunger = new[]{"ravenously ", "savagely ", "brutally ", "enthusiastically ", "frantically ", "sadistically "};
		string[] eat = new[]{"inhales", "chomps", "dissolves", "shreds", "eviscerates"};
		string[] sound = new[]{"slurping", "ripping", "cracking", "squishing", "snorting", "dripping"};
		string[] approval = new[]{"sated", "pacified", "content", "pleased", "docile", "placid"};
        result= "The creature opens its gaping maw and " + hunger[random.Next(0, hunger.Length)] + eat[random.Next(0,eat.Length)] + " your " + meal[random.Next(0,meal.Length)] + ". As the sound of " + sound[random.Next(0,sound.Length)] + " subsides, the creature appears to be " + approval[random.Next(0,approval.Length)] + "...for now.";
        return this;
    }
    public object play()
    {
        energy -=5;
		string[] location = new[]{"your backyard", "the woods near your house", "a park under the cover of darkness", "a condemned building", "a quarry", "a deserted field"};
		string[] shenanigans = new[] {"doing a little dance", "singing a nursery rhyme", "dangling a toy from a string", "drumming on the wall with two sticks"};
        if(random.Next(0,4)==0)
        {
            result= "You attempt to take the creature into " + location[random.Next(0,location.Length)] + "but it seems uninterested in your presence. You try to lift its spirits by " + shenanigans[random.Next(0,shenanigans.Length)] + ", but the creature simply stares vacantly past you until you are too exhausted to continue.";
            return this;
        }
        if(isWinner())
        {
            alive = false;
            result= "A winner is you!";
        }
        happiness += random.Next(5,11);
		string[] movement = new[]{"slither", "glide", "crawl", "stomp", "ooze", "skitter", "roll", "stroll", };
		string[] thought = new[]{"feet", "centipedes", "sand", "metal", "ashes", "sulfur"};
		string[] bizarre = new[] {"catches a small animal and turns it inside out." , "jumps into your mouth and crawls around inside your skull, making you think about " + thought[random.Next(0,thought.Length)]+ ".", "arranges random debris into the shape of a pentagram.", "wraps itself around a stone and absorbs its essence, growing slightly larger."};
        result= "You lead the creature into " + location[random.Next(0,location.Length)] + " and watch it " + movement[random.Next(0,movement.Length)] + " about. You decide it's time to call it a day after it " + bizarre[random.Next(0,bizarre.Length)];
        return this;
    }
    public object work()
    {
        if(energy >=5)
        {
			string[]prey = new[] {"sparrow", "squirrel", "rabbit", "stray cat", "rat", "frog", "possum"};
			string[]method = new[] {"net", "snare", "box", "pit"};
			string[]discomfort= new[] {"squeamishly", "hesitantly", "nauseously", "remorsefully", "sorrowfully"};
            energy -=5;
            meals += random.Next(1,4);
            result= "You catch a " + prey[random.Next(0,prey.Length)] + " in a " + method[random.Next(0,method.Length)] + ". A bit of your soul dies as you " + discomfort[random.Next(0,discomfort.Length)] + " put it out of its misery. But as you place its corpse in your refrigerator, you tell yourself this must be done. Nothing but the finest for your little friend.";
            return this;
        }
        else
        {
            result= "You set out to find food for the creature, but are too plagued by what you have seen.  Perhaps some sleep is in order.";
            return this;
        }
    }
    public object sleep()
    {
        energy+=15;
        happiness -=5;
        fullness -=5;
		string[] adjective = new[]{" gaunt ", " pale ", " slender ", " stern ", " hollow ", " soft ", " tense " ,"n emaciated ", " petrified ", " dark ", " corpulent ", " towering", " withered "};
		string[] subject = new[]{"woman", "priest", "tree", "obelisk", "snake", "apparition", "man", "child"};
		string[] message= new[]{"the cows have come home to roost.", "the chosen hand will fall.", "all shall be undone.", "the lessons of the ancients must be remembered.", "a new day is coming.", "this world will bow in humble supplication.", "mercy is for the unenlightened.", "this is all just a drop in a stream flowing upwards into The One True Ocean.", "what is dead may never die."};
		string nightmare = message[random.Next(0,message.Length)];
		if(nightmares.IndexOf(nightmare)==-1)
		{
			nightmares.Add(nightmare);
		}
		else{
			nightmare += " Your subconscious seems preoccupied with this wisdom.  What could it mean?";
		}
		
        if (happiness <=0 || fullness <=0)
		
        {
            alive=false;
			string[] nonverbal = new[] {"squeal", "chitter", "growl", "roar", "snarl", "hum", "chant"};
			string[] fear = new[] {"dread", "terror", "panic", "angst", "horror"};
			string[] texture = new[] {"scaly", "slimy", "cold", "moist", "damp", "rough", "searing", "frigid"};
			string[] bodypart = new[]{"flagellum", "tentacle","foot","paw","prehensile tail","vine","proboscis"};
            result= "The creature stares intently at you, emitting a " + nonverbal[random.Next(0,message.Length)] + ". It appears to be displeased with your hospitality. You begin to back away slowly, seized with " + fear[random.Next(0,fear.Length)] +", but are stopped in your tracks by a " + texture[random.Next(0, texture.Length)] + " " + bodypart[random.Next(0,bodypart.Length)] + ". You will be its next meal.";
        }
        if(isWinner())
        {
            alive = false;
            result= "A winner is you!";
            return this;
        }
        result= "As the creature slumbers, so do you.  You dream of a" + adjective[random.Next(0,adjective.Length)] + subject[random.Next(0,adjective.Length)] + " whispering in your ear that " + nightmare;
		return this;
    }
    public bool isWinner()
    {
        if(fullness >= 150 && happiness >= 150 && energy >=150)
        {
            return true;
        }
        return false;
    }
    public bool Evolves()
    {
        if(fullness >= 100 && happiness >= 100 && energy >=100 && hasevolved==false)
        {
            this.hasevolved=true;
            return true;
        }
        return false;
    }
    }
	public class Eldritchabomination:Eldritchcreature
	{
        public object work()
    {
        if(energy >=5)
        {
			string[]prey = new[] {"order a pizza", "hire a maid", "take a drifter in for the night", "order a package", "put up an ad on a social media platform offering a free couch"};
			string[]method = new[] {"butcher knife", "rag soaked in chloroform", "rock", "hacksaw", "drugged glass of water"};
			string[]discomfort= new[] {"screams", "pleas for mercy", "moans", "twitching", "whimpers"};
            energy -=5;
            meals += random.Next(1,4);
            result= "You " + prey[random.Next(0,prey.Length)] + " and subdue your resulting visitor with a " + method[random.Next(0,method.Length)] + ". You barely notice their " + discomfort[random.Next(0,discomfort.Length)] + " as you prepare them for their ultimate purpose.";
            return this;
        }
        else
        {
            result= "You set out to find food for the creature, but have grown too exhausted by your rituals.  Perhaps some sleep is in order.";
            return this;
        }
    }
        public Eldritchabomination(int energy, int happiness, int fullness, int meals, bool alive=true, bool hasevolved=true, string result= "The creature has grown quite large and gobbles up your remaining food supplies.  You will need to find larger sources of food...")
        {
            this.energy=energy;
            this.happiness=happiness;
            this.fullness=fullness;
            this.meals=meals;
            this.alive=alive;
            this.hasevolved=true;
            this.result= "The creature has grown quite large and gobbles up your remaining food supplies.  You will need to find larger sources of food...";
        }
	}
}