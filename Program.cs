﻿namespace Mob_Dev;

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
                Console.Write("Choose your option: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Creating a deck of cards...");
                        try{
                            deck.CreateDeck();
                            Console.WriteLine("New deck created!");
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Shuffling the deck...");
                        try{
                            deck.Shuffle();
                            Console.WriteLine("Deck Shuffled!");
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Dealing a card...");
                        try{
                            Console.Write("How many? ");
                            var input = Console.ReadLine();
                            if(int.TryParse(input, out int num)){

                                List<Card> deal = deck.Deal(num);
                                foreach (Card card in deal)
                                {
                                    Console.WriteLine($"Suit: {card.Name} \tRank: {card.Suit}");
                                }
                            }
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();

                        break;
                    case "4":
                        try{
                            Console.WriteLine("Displaying the deck...");
                            deck.Display();
                        }catch(Exception e){
                            Console.WriteLine(e.Message);
                        }
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
                Console.Clear();
            }
     }
}