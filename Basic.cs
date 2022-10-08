namespace _Basic
{
    class Basic
    {
        // Q1 Source Code
        public void helloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        // Q2 Source Code
        public int sum2()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            int y = int.Parse(Console.ReadLine());
            return x + y;
        }

        // Q3 Source Code
        public double divide2()
        {
            Console.WriteLine("Enter the 1st Number: ");
            double x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            double y = int.Parse(Console.ReadLine());
            return x / y;
        }

        // Q4 Source Code
        public void printResults()
        {
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
        }

        // Q5 Source Code
        public void swapNum()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            int y = int.Parse(Console.ReadLine());

            int temp = x;
            x = y;
            y = temp;

            Console.WriteLine("After Swapping: ");
            Console.WriteLine(x);
            Console.WriteLine(y);

        }

        // Q6 Source Code
        public double multiply3()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 3rd Number: ");
            int z = int.Parse(Console.ReadLine());
            return x * y * z;
        }

        // Q7 Source Code
        public void AllOps2()
        {
            Console.WriteLine("Enter the 1st Number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the 2nd Number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Adding: {0}", x + y);
            Console.WriteLine("Subtracting: {0}", x - y);
            Console.WriteLine("Multiplying: {0}", x * y);
            Console.WriteLine("Dividing: {0}", x / y);
            Console.WriteLine("Modulo: {0}", x % y);
        }

        // Q8 Source Code
        public void multiplicationTable()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, i, x*i);
            }

        }

        // Q9 Source Code
        public int FindAvg4()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int a = int.Parse(Console.ReadLine());

            return (x + y + z + a) / 4;
        }

        // Q10 Source Code
        public void performFormula()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            int z = int.Parse(Console.ReadLine());

            Console.WriteLine("(x + y) * z = {0}\n(x * y) + (x * z) = {1}", (x + y) * z, (x * y) + (x * z));
        }

        // Q11 Source Code
        public void olderThan()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("You look older than {0}", x);
        }

        public void seperate4Lines()
        {
            Console.WriteLine("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine(x.ToString() + x.ToString() + x.ToString() + x.ToString());
            Console.WriteLine(x.ToString() + " " + x.ToString() + " " + x.ToString() + " " + x.ToString());
            Console.WriteLine("{0}{0}{0}{0}", x);
            Console.WriteLine("{0} {0} {0} {0}", x);
        }
    }
}
