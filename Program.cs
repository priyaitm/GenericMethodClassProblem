using System;

namespace GenericProb
{
    internal class Program
    {

        void ShowArray<T>(T[] arr)
        {
            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
           // Console.ReadLine();
        }

        public static T FindMax<T>(T var1, T var2, T var3) where T : IComparable<T>
        {
            T max = var1;

            if (var2.CompareTo(max) > 0)
            {
                max = var2;
            }

            if (var3.CompareTo(max) > 0)
            {
                max = var3;
            }

            return max;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program program = new Program();
            int[] numbers = { 1, 2, 3 };
            string [] names = { "anu", "madhu", "radha" };
            char[] alpha = { 'A', 'B', 'c' };
            double[] doubles = { 1.2, 6.8, 9.8, };

            //program.ShowArray(numbers);
            //program.ShowArray(names);
            //program.ShowArray(alpha);
            //program.ShowArray(doubles);


            GenericClassProb<int> obj = new GenericClassProb<int>(56);
            GenericClassProb<string> obj2 = new GenericClassProb<string>("Priya");
            GenericClassProb<float> obj3 = new GenericClassProb<float>(56.9f);
            GenericClassProb<decimal> obj4 = new GenericClassProb<decimal>(86.9m);

            //Console.WriteLine(obj.GetBox());
            //Console.WriteLine(obj2.GetBox());
            //Console.WriteLine(obj3.GetBox());
            //Console.WriteLine(obj4.GetBox());



            Console.WriteLine(FindMax(34,45,67));
            Console.WriteLine(FindMax(78.8f, 67.8f,89.9f));
            Console.WriteLine(FindMax("Priya","Anuradha","Madhu"));
            




            Console.ReadLine();

        }
    }
}
