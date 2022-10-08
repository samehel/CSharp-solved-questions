namespace For_Loop
{
    class ForLoop
    {
        // Q3 - 1
        public void displayNTerms()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += (i + 1);
                Console.Write("{0}\t", i + 1);
            }

            Console.WriteLine("\nThe Sum of Natural Numbers upto {0} terms is: {1}", n, sum);

        }

        // Q5 - 2
        public void cubeNum()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("The current number is {0} and the cube of {0} is {1}", i+1, Math.Pow(i+1, 3));
            }
        }


        // Q6 - 3
        public void timesTable()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}", n, i+1, n * (i+1));
            }

        }

        // Q8 - 4
        public void oddNums()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("The odd numbers are: ");

            int sum = 0;
            int i = 0;
            while(i < n)
            {
                if ((i + 1) % 2 != 0)
                {
                    Console.Write(" {0} ", i + 1);
                    sum += (i + 1);
                } else
                {
                    n++;
                }
                i++;
            }
            Console.WriteLine("\nThe sum of odd numbers upto {0} terms is: {1}", n, sum);
        }

        // Q15 - 5
        public void factorial()
        {
            Console.Write("Input N: ");
            int n = int.Parse(Console.ReadLine());

            int sum = 1;
            for(int i = 0; i < n;  i++)
            {
                sum *= (i + 1);
            }
            Console.WriteLine("The Factorial of {0} is: {1}", n, sum);
        }

    }
}
