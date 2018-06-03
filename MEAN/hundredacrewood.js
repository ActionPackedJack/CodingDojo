var winniethepooh= {character:"Winnie the Pooh"};
var tigger = { character: "Tigger", south: winniethepooh};
var piglet = {character:"Piglet"};
var christopherrobin = {character:"Christopher Robin"};
var heffaslump = {character:"Heffalumps"};
var bees = {character:"bees"};
var kanga= {character: "Kanga"};
var owl = {character: "Owl"};
var gopher= {character: "Gopher"};
var eeyore= {character: "Eeyore"};
var rabbit= {character: "Rabbit"};
var location = tigger;
winniethepooh.north=tigger;
tigger.north = christopherrobin;

function move(direction){
    for (var key in location){
       // console.log(key.toString());
        if(key.toString()==direction){
        console.log (location[key]);
        location=location[key];
        }
    }
    console.log("You are now at " + location.character + "'s house.")
}
move("north");