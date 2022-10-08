namespace DataTypes
{
    class Data_Types
    {

        // Q1 Source
        public void inverse(char x, char y, char z)
        {
            Console.WriteLine("{0} {1} {2}", z, y, x);
        }

        // Q2 Source
        public void printTriangle(int num, int width)
        {
            int currWidth = 6;
            for(int i = 0; i < width; i++)
            {
                for (int j = 0; j < currWidth; j++)
                {
                    Console.Write("{0}", num);
                }
                Console.WriteLine();
                currWidth--;
            }
        }

        // Q3 Source
        public void login()
        {
            string user = "admin";
            string pass = "admin";
            int attempts = 3;

            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter your username: ");
                string username = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (username == user && password == pass) {
                    Console.WriteLine("Login Successful!");
                    break;
                } else
                {
                    attempts--;
                    Console.WriteLine("Login Failed! You have {0} attempts left.", attempts);
                    if(attempts == 0)
                        break;
                }

            }

            if (attempts == 0)
                Console.WriteLine("Request rejected. You are no longer allowed to login.");

        }

        // Q4 Source
        public void calculator()
        {
            string operation = "";
            bool firstTime = true;

            Console.Write("Input first number: ");
            int num1 = int.Parse(Console.ReadLine());

            do {
                if (firstTime == false && (operation != "+" || operation != "-" || operation != "*" || operation != "/"))
                {
                    Console.WriteLine("Invalid Operator...");
                }
                firstTime = false;
                Console.Write("Enter operation: ");
                operation = Console.ReadLine();
            } while (operation != "+" && operation != "-" && operation != "*" && operation != "/");
            
            Console.Write("Input second number: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, num1 + num2);
                    break;
                case "-":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, num1 - num2);
                    break;
                case "*":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, num1 * num2);
                    break;
                case "/":
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, num1 / num2);
                    break;
            }
        }

        // Q5 Source
        public void areaOfCircle()
        {
            Console.Write("Input the radius of the circle: ");
            int rad = int.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(rad, 2);
            double perimeter = 2 * Math.PI * rad;

            Console.WriteLine("The Area of the circle: {0}", area.ToString("#.##"));
            Console.WriteLine("The Perimeter of the circle: {0}", perimeter.ToString("#.##"));
        }

        // Q6 Source
        public void calculateEquation()
        {
            int y = -5;
            for(int i = 0; i < 11; i++)
            {
                double eqVal = Math.Pow(y, 2) + (2 * y) + 1;
                Console.WriteLine("x = {0}^2 + 2({0}) + 1 = {1}", y, eqVal);
                y++;
            }
        }

        // Q7 Source
        public void calculateSpeed()
        {
            Console.Write("Enter the distance in meters: ");
            double distance = double.Parse(Console.ReadLine());
            Console.Write("Enter time(hours): ");
            int hour = int.Parse(Console.ReadLine());
            Console.Write("Enter time(minutes): ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Enter time(seconds): ");
            int sec = int.Parse(Console.ReadLine());

            double time = (hour * 60.0 * 60.0) + (min * 60.0) + sec;

            Console.WriteLine("Your speed in meters/sec is: {0}", distance / time);
            Console.WriteLine("Your speed in km/h is: {0}", (distance/ 1000.0f) / (time/ 3600.0f));
            Console.WriteLine("Your speed in mi/h is: {0}", ((distance / 1000.0f) / (time / 3600.0f)) / 1.609f);

        }

        // Q8 Source
        public void areaOfSphere()
        {
            Console.Write("Input the radius of the sphere: ");
            int rad = int.Parse(Console.ReadLine());

            double surfaceArea = 4 * Math.PI * Math.Pow(rad, 2);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow(rad, 3);

            Console.WriteLine("Surface Area: {0}", surfaceArea.ToString("#.#####"));
            Console.WriteLine("Volume: {0}", volume.ToString("#.#####"));

        }

        // Q9 Source
        public void checkInputSymbol()
        {
            Console.Write("Input a symbol: ");
            char symbol = Char.Parse(Console.ReadLine());

            if (symbol == 'a' || symbol == 'a' || symbol == 'i' || symbol == 'o' || symbol == 'u')
                Console.WriteLine("Vowel");
            else if (symbol >= '0' && symbol <= '9')
                Console.WriteLine("Digit");
            else
                Console.WriteLine("Symbol");

        }

        // Q10 Source
        public void EvenOrOdd()
        {
            Console.Write("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0 && num2 % 2 == 0)
                Console.WriteLine(true);
            else if (num1 % 2 != 0 && num2 % 2 != 0)
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }

        // Q11 Source
        public void convertToBinary()
        {
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary: {0}", result);
        }
    }
}
