namespace Mob_Dev;

class Card{
    public string Name {get; }
    public string Suit {get; }
    public int Value {get; }
    public Card(string name, string suit, int value){
        Name = name;
        Suit = suit;
        Value = value;
    }
}