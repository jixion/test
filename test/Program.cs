namespace test
{
    using static System.Console;
    using System;
    class LinkedListGoodness
    {

        public static void Statistics(int[] array, int els, out int high, out int low, out int sum, out double avg)
        {
            int l = 0, h = 0, s = 0;
            for (int i = 0; i < els; i++)
            {
                if (i == 0)
                {
                    l = array[i];
                    h = array[i];
                } else {
                    if (array[i] < l) l = array[i];
                    if (array[i] > h) h = array[i];
                }
                s += array[i];
            }
            high = h;
            low = l;
            sum = s;
            avg = s / els;
        }
        static void Main(string[] args)
        {
            //int[] test = { 100, 200, 300, 400, 500 };
            //int high, low, sum;
            //double avg;
            //Statistics(test, 5, out high, out low, out sum, out avg);
            //WriteLine(high);
            //WriteLine(low);
            //WriteLine(sum);
            //WriteLine(avg);

            Random rnd = new();
            int computerChoice = rnd.Next(1, 4);
            Write("Enter r, p, or s: ");
            string choice = ReadLine();

            if (computerChoice == 1)
            {
                if (choice == "p")
                {
                    WriteLine("Computer: Rock vs. You: Paper");
                    WriteLine("Paper Beats Rock!");
                    WriteLine("You win!");
                } else if (choice == "s") { 
                    WriteLine("Computer: Rock vs. You: Scissors");
                    WriteLine("Rock Beats Scissors!");
                    WriteLine("You lose!");
                } else {
                    WriteLine("Computer: Rock vs. You: Rock");
                    WriteLine("You tied!");
                }
            }
            if (computerChoice == 2)
            {
                if (choice == "r")
                {
                    WriteLine("Computer: Paper vs. You: Rock");
                    WriteLine("Paper Beats Rock!");
                    WriteLine("You Lose!");
                } else if (choice == "s") {
                    WriteLine("Computer: Paper vs. You: Scissors");
                    WriteLine("Scissors Beats Paper!");
                    WriteLine("You Win!");
                } else {
                    WriteLine("Computer: Paper vs. You: Paper");
                    WriteLine("You tied!");
                }
            }
            if (computerChoice == 3)
            {
                if (choice == "p") {
                    WriteLine("Computer: Scissors vs. You: Paper");
                    WriteLine("Scissors Beats Paper!");
                    WriteLine("You Lose!");
                } else if (choice == "r") {
                    WriteLine("Computer: Scissors vs. You: Rock");
                    WriteLine("Rock Beats Scissors!");
                    WriteLine("You Win!");
                } else {
                    WriteLine("Computer: Scissors vs. You: Scissors");
                    WriteLine("You tied!");
                }
            }
        }
    }
}
