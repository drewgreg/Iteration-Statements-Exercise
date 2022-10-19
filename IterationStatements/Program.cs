namespace IterationStatements
{
    class Program
    {
        //Write a method that will print
        //to the console all numbers 1000 through -1000.
        public static void PrintThousand()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console
        //numbers 3 through 999 by 3 each time.
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }

        //Write a method to accept two integers as parameters
        //and check whether they are equal or not.
        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine("Correct!");
            }
        }

        //Write a method to check whether a given number is even or odd.
        public static void EvenOrOdd(int number)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("This number is even!");
            }
            else
            {
                Console.WriteLine("This number is odd!");
            }
        }

        //Write a method to check whether a given number is positive or negative.
        public static bool PosOrNeg(int num)
        {
            if (num > 0)
            {
                return true;
            }

            return false;

        }

        //Write a method to read the age of a candidate and determine
        //whether they can vote. Hint: use Parse()... or the safer TryParse()
        //for an extra challenge!!
        public static bool OfVotingAge(int age)
        {
            if (age >= 18)
            {
                Console.WriteLine($"You are of voting age!");
                return true;
            }
            else
            {
                Console.WriteLine($"Sorry, you are too young!");
                return false;
            }
        }

        //Write a method to check if an integer (from the user)
        //is in the range -10 to 10.
        public static bool NumberCheck()
        {
            Console.WriteLine("Pick a number between -10 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"Yes, that works!");
                return true;
            }
            else
            {
                Console.WriteLine("That doesn't work");
                return false;
            }
        }

        static void Main(string[] args)
        {
            PrintThousand();

            Threes();

            IsEqual(100, 100);

            EvenOrOdd(1001);

            PosOrNeg(100);

            OfVotingAge(10);

            NumberCheck();
        }
    }
}
