namespace Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<int> numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter an integer (or 'q' to quit): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    break;
                }

                 
                if (!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    continue;
                }

                if (numbers.Contains(number))
                {
                    try
                    {
                        throw new System.Exception("This Number is already Define !!!");
                    }catch(System.Exception e)
                    {
                        Console.WriteLine(e);
                    }
                  
                }

                numbers.Add(number);
                Console.WriteLine($"Number {number} added to the list.");
            }

            Console.WriteLine("List of unique numbers:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }



         
        public static void Vowel(string input)
        {
            bool hasVowels = false;
            foreach (char c in input.ToLower())
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    hasVowels = true;
                    break;
                }
            }

            if (!hasVowels)
            {
                try
                {
                    throw new System.Exception("this number is not Vowel !!");
                }catch(System.Exception e)
                {
                    Console.WriteLine(e);
                }
               
            }

            Console.WriteLine("The string contains vowels.");
        }
    }
}

