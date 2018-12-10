using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamIdea_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите версии программы для сравнения");
            string version1 = Console.ReadLine();
            string version2 = Console.ReadLine();
            version1 = version1.Replace(".", " ");
            version2 = version2.Replace(".", " ");
            string[] str1 = version1.Split(' ');
            int[] array1 = new int[str1.Length];
            for (int i = 0; i < str1.Length; i++)
            {
                array1[i] = Convert.ToInt32(str1[i]);
            }

            string[] str2 = version2.Split(' ');
            int[] array2 = new int[str2.Length];
            for (int i = 0; i < str2.Length; i++)
            {
                array2[i] = Convert.ToInt32(str2[i]);
            }
            int chek = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if ((array1[i] == array2[i]) & (i+1 != array1.Length))
                {
                    continue;
                }
                else
                {
                    if (array1[i] > array2[i])
                    {
                        Console.WriteLine("Версия номер 1 новее");
                        chek = chek + 1;
                    }
                    else if (array1[i] < array2[i])
                    {
                        Console.WriteLine("Версия номер 2 новее");
                        chek = chek + 1;
                    }
                }

                if (chek == 0)
                {
                    Console.WriteLine("Версии программы одинаковы");
                }

            }




            Console.ReadKey();

        }
    }
}
