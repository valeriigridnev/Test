using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamIdea_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (N / 5 > 0)
            {
                count = count + N / 5;
                N = N / 5;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
