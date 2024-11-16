using System;

namespace CharacterCopier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Check if input string is provided as an argument
            string input = args.Length > 0 ? string.Join(" ", args) : null;

            // If no input provided, prompt the user
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Enter a string to copy (input ends with newline):");
                input = Console.ReadLine() ?? string.Empty;
            }

            // Initialize the source and destination
            ISource source = new StringSource(input);
            IDestination destination = new ConsoleDestination();

            // Copy characters from source to destination
            Copier copier = new Copier(source, destination);
            copier.Copy();

            Console.WriteLine("\nCopy completed!");
        }
    }

    public class StringSource : ISource
    {
        private readonly string _data;
        private int _index;

        public StringSource(string data)
        {
            _data = data;
            _index = 0;
        }

        public char ReadChar()
        {
            if (_index >= _data.Length)
            {
                return '\0'; // Simulate end of source
            }

            return _data[_index++];
        }
    }

    public class ConsoleDestination : IDestination
    {
        public void WriteChar(char c)
        {
            Console.Write(c);
        }
    }
}
