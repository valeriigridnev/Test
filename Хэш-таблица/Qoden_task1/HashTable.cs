using System;

namespace Qoden_task1
{
    public class HashTable
    {
        public ListNode[] values;
        public int N;

        public HashTable(int n)
        {
            N = n;
            values = new ListNode[N];
        }

        public void Insert(int newValue)
        {
            ListNode p = values[newValue % N];
            if (p != null)
            {
                while (p.next != null)
                {
                    p = p.next;
                }

                p.next = new ListNode();
                p.next.Insert(newValue);
            }
            else
            {
                values[newValue % N] = new ListNode();
                values[newValue % N].Insert(newValue);
            }
        }

        public void Print()
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != null)
                    Console.WriteLine(i + ": " + values[i].ToString());
                else
                    Console.WriteLine(i + ": ");
            }
        }
    }
}