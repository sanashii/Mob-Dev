namespace Mob_Dev;
class Deck
{
    public Stack<Card> Cards { get; set; }

    public Deck(){
        Cards = new Stack<Card>();
    }
    public void CreateDeck()
    {
        if(Cards.Count>0){
            throw new CustomExceptions.DeckInitializationException("Deck already exist.");
        }

        string[] suits = { "Spades", "Hearts", "Diamonds", "Clubs" };
        string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9",
        "10",  "Ace", "Jack", "Queen", "King" };
        foreach (var suit in suits)
        {
            foreach (var rank in ranks)
            {
                Card card = new Card(rank, suit, 0);
                if(!Cards.Contains(card))
                {
                    Cards.Push(card);
                }
            }
        }
    }
    public void Display()
    {
        if(Cards.Count==0){
            throw new CustomExceptions.EmptyDeckException();
        }
        foreach (Card card in Cards)
        {
            Console.WriteLine($"Suit: {card.Name} \tRank: {card.Suit}");
        }
        Console.WriteLine($"Number of cards: {Cards.Count}");
    }


    public void Shuffle(){
        if(Cards.Count == 0){
            throw new CustomExceptions.EmptyDeckException();
        }
        List<Card> list = new List<Card>(Cards);
        list = [.. list.OrderBy(x=> Random.Shared.Next())];
        Cards.Clear();

        foreach (Card card in list){
            Cards.Push(card);
        }
    }

    public List<Card> Deal(int count){
        if (Cards.Count == 0)
            throw new CustomExceptions.EmptyDeckException();
        if (count < 0 || count > Cards.Count)
            throw new ArgumentOutOfRangeException(null, "Cannot deal if deck has fewer cards than the requested number.");

        List<Card> deal = new List<Card>();
        while(count != 0){
            count--;
            deal.Add(Cards.Pop());
        }
        return deal;
    }

}