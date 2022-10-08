using System.Collections;

namespace _Array
{
    class Array
    {

        // Q1 Source
        public void storeElements()
        {
            ArrayList arrayList = new ArrayList();

            for(int i = 0; i < 10; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                arrayList.Add(element);
            }
            Console.Write("The list of elements are:");
            foreach (int num in arrayList)
                Console.Write(" {0} ", num);

        }

        // Q2 Source
        public void reverseArray()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                arrayList.Add(element);
            }

            Console.Write("\nThe list of elements before being reversed are:");
            foreach (int num in arrayList)
                Console.Write(" {0} ", num);

            arrayList.Reverse();

            Console.Write("\nThe list of elements after being reversed are:");
            foreach (int num in arrayList)
                Console.Write(" {0} ", num);

        }

        // Q3 Source
        public void sumElements()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                arrayList.Add(element);
            }

            int sum = 0;
            for(int i = 0; i < arrayList.Count; i++)
            {
                sum += (int)arrayList[i];
            }

            Console.WriteLine("Sum of all the elements in the array is: {0}", sum);

        }

        // Q4 Source
        public void copyElements()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                arrayList.Add(element);
            }

            ArrayList arrayList2 = new ArrayList();

            for(int i = 0; i < arrayList.Count; i++)
            {
                arrayList2.Add(arrayList[i]);
            }

            Console.Write("\nElements in the first array are: ");
            foreach (int num in arrayList)
                Console.Write(" {0} ", num);

            Console.Write("\nElements in the second array are: ");
            foreach (int num in arrayList2)
                Console.Write(" {0} ", num);

        }

        // Q6 Source
        public void uniqueElements()
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element {0}: ", i + 1);
                int element = int.Parse(Console.ReadLine());
                arrayList.Add(element);
            }

            
            ArrayList unique = new ArrayList();

            for(int i = 0; i < arrayList.Count; i++)
            {
                int dupsFound = 0;
                for (int j = 0; j < arrayList.Count; j++)
                {
                    if (i == j)
                        continue;

                    if ((int)arrayList[i] == (int)arrayList[j] && !unique.Contains(arrayList[j]))
                    {
                        dupsFound+=1;
                    }

                }
                if(dupsFound == 0)
                    unique.Add(arrayList[i]);
            }

            Console.Write("\nUnique Elements are: ");
            foreach (int num in unique)
                Console.Write(" {0} ", num);

        }

    }
}
