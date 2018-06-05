var cardTypes= ["2","3","4","5", "6","7","8","9","10","Jack","Queen","King","Ace"]

var suitNames=["Spades","Hearts","Clubs","Diamonds"];

function deck(){
    this.cards =[];
    function Card(type, suit){
        this.type=type;
        this.suit = suit;
    }
    for(var i=0;i<suitNames.length;i++){
        for(var j=0;j<cardTypes.length;j++){
            nextcard= new Card(cardTypes[j],  suitNames[i]);
            this.cards.push(nextcard);
        }
    }
    this.shuffle =function(){
        for( var card in this.cards){
            var index= Math.floor(Math.random()*(this.cards.length-1))
            var temp = this.cards[index];
            this.cards[index]=this.cards[card];
            this.cards[card]=temp;
        }
    }
    this.deal= function(){
        return this.cards.pop();
    }
}

function Player(name, deck){
    this.name= name;
    this.hand = [];
    this.deck = deck;
    this.draw = function(){
        this.hand.push(this.deck.deal())
    }
    this.discard= function(){
        const discarded= (this.hand.pop());
        this.deck.push(discarded);
    }
}

const thedeck = new deck();
const player1 = new Player("Burtmore", thedeck);
thedeck.shuffle();
console.log(thedeck);   
player1.draw();
console.log(thedeck);
console.log(player1.hand);
player1.discard();
console.log(thedeck);
console.log(player1.hand);
