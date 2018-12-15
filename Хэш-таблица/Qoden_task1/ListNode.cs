using System;
using System.Text;

namespace Qoden_task1
{
    public class ListNode
    {
        int value;
        public ListNode next;

        public ListNode()
        {
            next = null;
        }

        public void Insert(int newValue)
        {
            value = newValue;
        }

        public override String ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(value + " ");
            ListNode p = next;
            while (p != null)
            {
                str.Append(p.value + " ");
                p = p.next;
            }

            return str.ToString();
        }
    }
}