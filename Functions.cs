namespace _Functions
{
    class Functions
    {

        public void power()
        {
            Console.Write("Enter the base number: ");
            double Base = double.Parse(Console.ReadLine());
            Console.Write("Enter the exponent: ");
            double exp = double.Parse(Console.ReadLine());

            Console.WriteLine("{0}^{1} = {2}", Base, exp, Math.Pow(Base, exp));

        }

    }
}
