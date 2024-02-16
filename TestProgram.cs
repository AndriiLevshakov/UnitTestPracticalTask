using System;

namespace Task
{
    public class TestProgram
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Please provide a sequence of symbols");
                string input = Console.ReadLine();
                TestProgram program = new TestProgram();
                int maxConsecutiveUnequalCharacters = program.GetMaxConsecutiveUnequalCharacters(input);
                int maxConsecutiveIdenticalLatinLetters = program.MaxConsecutiveIdenticalLatinLetters(input);
                int maxConsecutiveIdenticalDigit = program.MaxConsecutiveIdenticalDigits(input);
                Console.WriteLine("Input: {0}", input);
                Console.WriteLine("Maximum Consecutive Unequal Characters: {0}", maxConsecutiveUnequalCharacters);
                Console.WriteLine("Maximum Consecutive Identical Latin Letters: {0}", maxConsecutiveIdenticalLatinLetters);
                Console.WriteLine("Maximum Consecutive Identical Digits: {0}", maxConsecutiveIdenticalDigit);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please provide input via command-line arguments.");
            }
        }        

        public int GetMaxConsecutiveUnequalCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxConsecutive = 1;
            int currentConsecutive = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentConsecutive++;
                    if (currentConsecutive > maxConsecutive)
                    {
                        maxConsecutive = currentConsecutive;
                    }
                }
                else
                {
                    currentConsecutive = 1;
                }
            }

            return maxConsecutive;
        }

        public int MaxConsecutiveIdenticalLatinLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxConsecutive = 1;
            int currentConsecutive = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]) && (input[i] == input[i - 1]))
                {
                    currentConsecutive++;
                    if (currentConsecutive > maxConsecutive)
                    {
                        maxConsecutive = currentConsecutive;
                    }
                }
                else
                {
                    currentConsecutive = 1;
                }
            }

            return maxConsecutive;
        }

        public int MaxConsecutiveIdenticalDigits(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }

            int maxConsecutive = 1;
            int currentConsecutive = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) && (input[i] == input[i - 1]))
                {
                    currentConsecutive++;
                    if (currentConsecutive > maxConsecutive)
                    {
                        maxConsecutive = currentConsecutive;
                    }
                }
                else
                {
                    currentConsecutive = 1;
                }
            }

            return maxConsecutive;
        }
    }
}
