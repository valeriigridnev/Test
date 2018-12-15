using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qoden_task1
{
    class Program 
    {
        static void Main(string[] args)
        {

            int N = Convert.ToInt32(Console.ReadLine());

            HashTable table = new HashTable(N);
            string text= Console.ReadLine();
            string[] arg = text.Split();
            int[] array = new int[arg.Length];
            for (int i = 0; i < arg.Length; i++)
            {
                array[i] = Convert.ToInt32(arg[i]);
            }
            for (int i = 0; i < arg.Length; i++)
            {
                table.Insert(array[i]);
            }
            table.Print();
            Console.ReadKey();
        }
    }
}
