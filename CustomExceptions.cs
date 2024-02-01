using System;

// Class to contain custom exceptions
public static class CustomExceptions
{
    // Custom exception for an empty deck
    public class EmptyDeckException : Exception
    {
        public EmptyDeckException():base("Deck is empty!")
        {
        }
        public EmptyDeckException(string message) : base(message)
        {
        }

        public EmptyDeckException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    // Custom exception for invalid card operations
    public class ArgumentOutOfRangeException : Exception
    {
        public ArgumentOutOfRangeException(string message) : base(message)
        {
        }

        public ArgumentOutOfRangeException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    // Custom exception for deck initialization issues
    public class DeckInitializationException : Exception
    {
        public DeckInitializationException(string message) : base(message)
        {
        }

        public DeckInitializationException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
