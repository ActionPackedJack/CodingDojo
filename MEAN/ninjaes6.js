class Ninja {
    constructor(name){
        this.name=name;
        this.health=100;
        this.speed=3;
        this.strength=3;
    }
    showStats(){
        console.log("Name: " + this.name, "Health: " + this.health, "Speed:" + this.speed, "Strength: " + this.strength);
    }
    punch(target){
            target.health-=5;
            console.log(target.name + " was punched by " + this.name + " and lost 5 health!");
    }
    kick(target){
        var damage=3*this.strength;
        target.health-=damage;
        console.log(target.name + " was kicked by " + this.name + " and lost " + damage + " health!");
    }
    eatRice(){
        this.health+=10;
    }
}
class Sensei extends Ninja{
    constructor(name){
        super(name);
        this.health = 200;
        this.wisdom = 10;
        this.speed=10;
        this.strength=10;
    }
    speakWisdom(){
        this.eatRice();
        console.log("There are none so stabbed as those who will not see.")
    }
}

const Rikimaru= new Ninja("Rikimaru");
const Onikage = new Ninja("Onikage");
const Shiunsai = new Sensei("Shiunsai");

Rikimaru.punch(Onikage);
Onikage.kick(Rikimaru);
Rikimaru.showStats();
Onikage.showStats();
Shiunsai.speakWisdom();
Shiunsai.showStats();