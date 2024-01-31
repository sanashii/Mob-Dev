using Mob_Dev;
namespace Mob_Dev;

class Deck
{
    public Stack<Card> Cards { get; set; }

    public Deck(){
        Cards = new Stack<Card>();
    }
    public void CreateDeck()
    {
        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9",
        "10",  "Ace", "Jack", "Queen", "King" };
        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                Card card = new Card(rank, suit, 0);
                this.Cards.Push(card);
            }
        }
    }
    public void Display()
    {
        Console.WriteLine($"card test: {this.Cards.Peek().Name}");
        foreach (Card card in Cards)
        {
            Console.WriteLine($"Suit: {card.Name} \tRank: {card.Suit}");
        }
    }

}