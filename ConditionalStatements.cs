namespace ConditionalStatements
{
    class Conditional_Statements
    {
        // Q19 Source - 1
        public void gradeDescription()
        {
            bool flag = false;

            for (int i = 0; i == 0;)
            {
                Console.Write("Input a grade: ");
                char grade = Char.Parse(Console.ReadLine());

                switch (Char.ToUpper(grade))
                {
                    case ('E'):
                        Console.WriteLine("Excellent");
                        flag = true;
                        break;
                    case 'V':
                        Console.WriteLine("Very Good");
                        flag = true;
                        break;
                    case 'G':
                        Console.WriteLine("Good");
                        flag = true;
                        break;
                    case 'A':
                        Console.WriteLine("Average");
                        flag = true;
                        break;
                    case 'F':
                        Console.WriteLine("Fail");
                        flag = true;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid grade");
                        continue;
                }

                if (flag)
                    break;

            }
        }

        // Q22 - 2
        public void monthNumToString()
        {
            Console.Write("Input the month number: ");
            int monthNum = int.Parse(Console.ReadLine());

            switch(monthNum)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("Febuary");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Enter a valid month number!");
                    break;
            }
        }

        // Q8 - 3
        public void findLargest()
        {
            Console.Write("Input first num: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Input second num: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.Write("Input third num: ");
            int thirdNum = int.Parse(Console.ReadLine());

            int[] numbers = { firstNum, secondNum, thirdNum };

            int max = -999;

            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > max)
                    max = numbers[i];
            }

            Console.WriteLine("The largest number is: {0}", max);

        }

        // Q3 - 4
        public void numSign()
        {
            Console.Write("Input num: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is {0}", num < 0 ? "negative" : "postive");
        }

        // Q6 - 5
        public void displayN()
        {
            Console.Write("Input num: ");
            int m = int.Parse(Console.ReadLine());

            int n = 0;

            if (m > 0)
                n = 1;
            else if (m == 0)
                n = 0;
            else if (m < 0)
                n = -1;

            Console.WriteLine("The value of n = {0}", n);

        }

        // Q2 - 6
        public void oddOrEven()
        {
            Console.Write("Input num: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("The number is {0}", num % 2 == 0 ? "even" : "odd");

        }

        // Q18 - 7
        public void generateEletricBill()
        {
            Console.Write("Enter your customer ID, Name and total units consumed (ex. 1010 John 500): ");
            string data = Console.ReadLine();

            string[] words = data.Split(" ");

            string ID = words[0];
            string name = words[1];
            int units = int.Parse(words[2]);

            double chargeRate = 0.0;
            double surcharge = 0.0;

            if (units <= 199)
                chargeRate = 1.20;
            else if (units >= 200 && units < 400)
                chargeRate = 1.50;
            else if (units >= 400 && units < 600)
                chargeRate = 1.80;
            else if (units >= 600)
                chargeRate = 2.00;
            else
            {
                Console.WriteLine("Write a valid unit amount!");
                Environment.Exit(-1);
            }

            double bill = chargeRate * units;

            if (bill > 400)
                surcharge = 0.15 * bill;


            Console.WriteLine("-----------------------------------");
            Console.WriteLine("---------- ELECTRIC BILL ----------");
            Console.WriteLine("Customer IDNO: {0}", ID);
            Console.WriteLine("Customer Name: {0}", name);
            Console.WriteLine("Units Consumed: {0}", units);
            Console.WriteLine("Amount Charged @ {0} per unit: {1}", chargeRate.ToString("0.00"), bill.ToString("0.00"));
            Console.WriteLine("Surchage Amount: {0}", surcharge.ToString("0.00"));
            Console.WriteLine("Net Amount Paid by the Customer: {0}", (bill + surcharge).ToString("0.00"));
            Console.WriteLine("-----------------------------------");
        }

        // Q24 - 8
        public void calculateShapeArea()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("----------- Select Shape ----------");
                Console.WriteLine("1 - Circle \t\t 2 - Square");
                Console.WriteLine("3 - Rectangle \t\t 4 - Triangle");
                Console.WriteLine("-----------------------------------");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius of the circle: ");
                        double rad = double.Parse(Console.ReadLine());
                        Console.WriteLine("The Area of the circle is: {0}", Math.PI * Math.Pow(rad, 2));
                        flag = false;
                        break;
                    case 2:
                        Console.WriteLine("Enter the side of the square: ");
                        double side = double.Parse(Console.ReadLine());
                        Console.WriteLine("The Area of the square is: {0}", Math.Pow(side, 2));
                        flag = false;
                        break;
                    case 3:
                        Console.WriteLine("Enter the length of the rectangle: ");
                        double len = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the width of the rectangle: ");
                        double width = double.Parse(Console.ReadLine());
                        Console.WriteLine("The Area of the rectangle is: {0}", len * width);
                        flag = false;
                        break;
                    case 4:
                        Console.WriteLine("Enter the height of the triangle: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the base of the triangle: ");
                        double bse = double.Parse(Console.ReadLine());
                        Console.WriteLine("The Area of the triangle is: {0}", (1.0/2.0 * bse * height));
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid choice!");
                        Thread.Sleep(1500);
                        Console.Clear();
                        break;
                }
            }
        }

        // Q25 - 9
        public void calculator()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("------- Select an Operation -------");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Substraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("-----------------------------------");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Addition of {0} and {1} is: {2}", num1, num2, num1 + num2);
                    break;
                case 2:
                    Console.WriteLine("The Subtraction of {0} and {1} is: {2}", num1, num2, num1 - num2);
                    break;
                case 3:
                    Console.WriteLine("The Multiplication of {0} and {1} is: {2}", num1, num2, num1 * num2);
                    break;
                case 4:
                    Console.WriteLine("The Division of {0} and {1} is: {2}", num1, num2, num1 / num2);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }

        }

        // Q20 - 10
        public void numToDay()
        {
            Console.Write("Enter the day number: ");
            int dayNum = int.Parse(Console.ReadLine());

            switch(dayNum)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Please enter a valid choice!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    break;
            }

        }

        // Q17 - 11
        public void calculateProfitLoss()
        {
            Console.Write("Enter the amount spent and the amount generated (ex. 500 700): ");
            string data = Console.ReadLine();

            string[] money = data.Split(" ");

            int amountSpent = int.Parse(money[0]);
            int amountMade = int.Parse(money[1]);

            int totalAmount = amountMade - amountSpent;

            if (totalAmount < 0)
                Console.WriteLine("A loss of {0} was made", totalAmount);
            else if (totalAmount > 0)
                Console.WriteLine("A profit of {0} was made", totalAmount);
            else
                Console.WriteLine("No profit or loss was made, a breakeven occured.");

        }

        // Q12 - 12
        public void generateDivision()
        {
            Console.Write("Enter the Roll number of the student: ");
            string rollNum = Console.ReadLine();
            Console.Write("Enter the name of the student: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter the grades of Physics, Chemistry and Computer Science: ");
            string marksData = Console.ReadLine();
            string[] marks = marksData.Split(" ");
            string division = "";
            int totalMarks = int.Parse(marks[0]) + int.Parse(marks[1]) + int.Parse(marks[2]);
            double percentage = (totalMarks / 300.0) * 100.0;

            if (percentage >= 85)
                division = "First-Class Honours";
            else if (percentage >= 70 && percentage < 85)
                division = "Upper Second-Class Honours";
            else if (percentage >= 60 && percentage < 70)
                division = "Lower Second-Class Honours";
            else if (percentage >= 50 && percentage < 60)
                division = "Third-Class Honours";
            else
                division = "No Honours";

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("---------- STUDENT DATA -----------");
            Console.WriteLine("Roll No.: {0}", rollNum);
            Console.WriteLine("Name of Student: {0}", studentName);
            Console.WriteLine("Marks in Physics: {0}", marks[0]);
            Console.WriteLine("Marks in Chemistry: {0}", marks[1]);
            Console.WriteLine("Marks in Computer Science: {0}", marks[2]);
            Console.WriteLine("Total Marks: {0}", totalMarks);
            Console.WriteLine("Percentage: {0}%", percentage.ToString("0.00"));
            Console.WriteLine("Division: {0}", division);
            Console.WriteLine("-----------------------------------");

        }
    }
}
