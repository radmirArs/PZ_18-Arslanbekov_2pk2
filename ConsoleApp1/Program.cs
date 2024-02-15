namespace ConsoleApp1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string StateNumber = "AB 123 XY";
            StateNum(StateNumber);

        }

        public static bool StateNum(string StateNumber)
        {
            bool State;
            if (StateNumber.Length != 9)
            {
                Console.WriteLine("f1");
                return false;
            }

            for (int i = 0; i < 2; i++)
            {
                if (!char.IsLetter(StateNumber[i]))
                {
                    Console.WriteLine("f2");
                    return false;
                }
            }

            for (int i = 3; i < 6; i++)
            {
                if (!char.IsDigit(StateNumber[i]))
                {
                    Console.WriteLine("f3");
                    return false;
                }
            }

            for (int i = 7; i < 8; i++)
            {
                if (!char.IsLetter(StateNumber[i]))
                {
                    Console.WriteLine("f4");
                    return false;
                }
            }
            Console.WriteLine("t");
            return true;
        }


    }
}

