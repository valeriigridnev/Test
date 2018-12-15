using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qoden_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] array = input.Split(' ');
            Stack<double> st = new Stack<double>();
            for (int i = 0; i < array.Length; i++)
            {
                double num;
                bool isNum = double.TryParse(array[i],out num);
                if (isNum)
                {
                    st.Push(num);
                }
                else
                {
                    double op2;
                    switch (array[i])
                    {
                        case "+":
                            st.Push(st.Pop() + st.Pop());
                            break;
                        case "*":
                            st.Push(st.Pop() * st.Pop());
                            break;
                        case "-":
                            op2 = st.Pop();
                            st.Push(st.Pop() - op2);
                            break;
                        case "/":
                            op2 = st.Pop();
                                st.Push(st.Pop() / op2);
                            break;
                    }

                }


            }
            Console.WriteLine(st.Pop());

        }
    }
}