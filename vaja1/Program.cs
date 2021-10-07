using System;

namespace vaja1
{
    class Program
    {
        static void Main(string[] args)
        {              
            int a ,b ,c;

            Console.WriteLine("Enter value of 'a': ");        
            while (!int.TryParse(Console.ReadLine(), out a)){
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of 'a': ");         
            }
            
            Console.WriteLine("Enter value of 'b': ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.Clear();
                Console.WriteLine("You entered an invalid number");
                Console.Write("Enter value of 'b': ");
            }

            Console.Clear();
            c = Add(a, b);
            Console.WriteLine("Result: a + b = {0}", c);
        }
        public static int Add(int x, int y)
        {
            int result = x + y;
            return result;
        }
    }
}
