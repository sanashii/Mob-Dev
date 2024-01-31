using Mob_Dev;

class Program
{
        static void Main()
        {
            Deck deck = new Deck();
            while (true)
            {
                Console.WriteLine(@"Deck of Cards
                1 - Create a deck of cards
                2 - Shuffle the deck
                3 - Deal a card
                4 - Display the deck
                5 - Exit");
                Console.WriteLine("Choose your fighter: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Creating a deck of cards...");
                        deck.CreateDeck();
                        break;
                    case "2":
                        Console.WriteLine("Shuffling the deck...");
                        break;
                    case "3":
                        Console.WriteLine("Dealing a card...");
                        break;
                    case "4":
                        Console.WriteLine("Displaying the deck...");
                        try{
                            deck.Display();
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        break;
                }
            }
     }
}