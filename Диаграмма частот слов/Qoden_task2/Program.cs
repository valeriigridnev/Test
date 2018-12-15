using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Qoden_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> words = new Dictionary<string, double>();
            Dictionary<string, double> words2 = new Dictionary<string, double>();
            string text = Console.ReadLine();
            string[] array = text.Split(' ');
            int maxBukv = 0;
            double max4ast = 0;
            double vsego = array.Length;
            #region Максимальное кол-во букв в слове
            for (int i = 0; i < array.Length; i++)
            {
                if (maxBukv > array[i].Length)
                    continue;
                else
                {
                    maxBukv = array[i].Length;
                }
            }



            #endregion
            #region Заполнение words

            for (int i = 0; i < array.Length; i++)
            {
                double k = 1;
                if (true == words.ContainsKey(array[i]))
                {
                    k = words[array[i]] + 1;
                    words.Remove(array[i]);
                    words.Add(array[i], k);
                }
                else
                {
                    words.Add(array[i], 1);
                }
            }

            #endregion
            #region Заполнение words2
            foreach (var word in words)
            {
                double k;
                k = word.Value/ vsego;
                words2.Add(word.Key, k);
            }
            #endregion
            #region Нахождение максимальной частоты
            foreach (var word in words2)
            {
                if (word.Value > max4ast)
                    max4ast = word.Value;
            }
            #endregion
            #region Вывод
            foreach (var word in words2.OrderBy(pair => pair.Value))
            {
                double otn4ast = Math.Ceiling((word.Value / max4ast) * 10);

                if (word.Key.Length != maxBukv)
                {
                    for (int i = 0; i < (maxBukv - word.Key.Length); i++)
                    {
                        Console.Write("_");
                    }
                    Console.Write(word.Key + " ");
                }
                else
                {
                    Console.Write(word.Key + " ");
                }

                for (int i = 0; i < otn4ast - 1; i++)
                {
                    Console.Write(".");
                }
                Console.WriteLine(".");
            }
            #endregion
        }
    }
}
