namespace _String
{
    class String
    {
        // Q7 - 1
        public void stringInfo()
        {
            Console.WriteLine("Write a string: ");
            string line = Console.ReadLine();

            int alphabet = 0;
            int digits = 0;
            int specialChars = 0;

            for(int i = 0; i < line.Length; i++)
            {
                if (line[i].ToString().All(char.IsDigit))
                    digits++;
                else if (line[i].ToString().All(char.IsLetter))
                    alphabet++;
                else
                    specialChars++;
            }

            Console.WriteLine("Number of Alphabets in the string is: {0}", alphabet);
            Console.WriteLine("Number of Digits in the string is: {0}", digits);
            Console.WriteLine("Number of Special Chars in the string is: {0}", specialChars);


        }

        // Q13 - 2
        public void cutString()
        {
            Console.WriteLine("Write a string: ");
            string line = Console.ReadLine();
            Console.WriteLine("Enter the start pos: ");
            int startPos = int.Parse(Console.ReadLine());
            Console.WriteLine("Write the length to cut: ");
            int len = int.Parse(Console.ReadLine());

            Console.WriteLine("The substring is: {0}", line.Substring(startPos, len));


        }

        // Q14 - 3
        public void checkStringContents()
        {
            Console.WriteLine("Write a string: ");
            string line = Console.ReadLine();
            Console.WriteLine("Write the substring: ");
            string substr = Console.ReadLine();

            if (line.Contains(substr))
                Console.WriteLine("The substring exists in the string");
            else
                Console.WriteLine("The substring does not exist in the string");

        }



    }
}
