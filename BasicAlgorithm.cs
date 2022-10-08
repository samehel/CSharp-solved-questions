namespace BasicAlgorithm
{
    class Basic_Algorithm
    {
        // Q1 Source
        public int trippleSum(int x, int y)
        {
            int sum = x + y;

            if (x == y)
                sum *= 3;

            return sum;
        }

        // Q2 Source
        public int absoluteDifference(int x)
        {
            int difference;
            const int num = 51;

            if (x > num)
                difference = (x - num) * 3;
            else
                difference = num - x;

            return difference;
        }

        // Q3 Source
        public bool thirtyChecker(int x, int y)
        {
            bool thirty = false;

            if(x + y == 30 || x == 30 || y == 30)
                thirty = true;

            return thirty;
        }

        // Q4 Source
        public bool withinRange(int x)
        {
            bool withinRange = false;

            if (x < 100 && x >= 90)
                withinRange = true;
            else if (x > 100 && x <= 110)
                withinRange = true;
            else if (x < 200 && x >= 190)
                withinRange = true;
            else if (x > 200 && x <= 210)
                withinRange = true;

            return withinRange;
        }

        // Q5 Source
        public string addToString(string x)
        {
            if (x.StartsWith("if"))
                return x;
            else
                return "if " + x;
        }

        // Q6 Source
        public string removeChar(string x, int pos)
        {
            return x.Remove(pos, 1);
        }

        // Q7 Source
        public string swapChars(string x)
        {
            if (x.Length == 1)
                return x;

            char a = x[0];
            char b = x[x.Length - 1];

            string swapped = "";

            for(int i = 0; i < x.Length; i++)
            {
                if (i == 0)
                    swapped += b;
                else if (i == x.Length - 1)
                    swapped += a;
                else
                    swapped += x[i];
            }


            return swapped;
        }

        // Q8 Source
        public void repeatString(string x)
        {
            if (x.Length < 2)
                Console.Write(x);
            else
            {
                string repeat = x.Substring(0, 2);

                for (int i = 0; i < 4; i++)
                {
                    Console.Write(repeat);
                }
                Console.WriteLine();
            }
        }

        // Q9 Source
        public string moveToFrontAndBack(string x)
        {
            char lastChar = x[x.Length - 1];
            string moved = lastChar + x + lastChar;

            return moved;
        }

        // Q10 Source
        public bool multiple37(int x)
        {
            if (x % 3 == 0 || x % 7 == 0)
                return true;

            return false;
        }

        // Q11 Source
        public string add3(string x)
        {
            if (x.Length < 3)
                return x + x + x;

            string firstThree = x.Substring(0, 3);

            return firstThree + x + firstThree;
        }

        // Q12
        public bool startsWithCSharp(string x)
        {
            return x.StartsWith("C#") ? true : false;
        }

    }
}
