using LeetCode.Common;
using System.Collections.Generic;
using System.ComponentModel;

namespace LeetCode.Normal
{
    public class AddTwoNumbers
    {
        public int[] AddTwoNumbersResult(ListNode l1, ListNode l2)
        {
            Queue<int> l1Queue = new Queue<int>();
            Queue<int> l2Queue = new Queue<int>();

            Queue<int> max;
            Queue<int> min;

            for (ListNode item = l1; item != null; item = item.next)
            {
                l1Queue.Enqueue(item.val);
            }

            for (ListNode item = l2; item != null; item = item.next)
            {
                l2Queue.Enqueue(item.val);
            }

            if (l1Queue.Count >= l2Queue.Count)
            {
                max = l1Queue;
                min = l2Queue;
            }
            else
            {
                max = l2Queue;
                min = l1Queue;
            }

            Queue<int> result = new Queue<int>();

            int flag = 0;
            while (max.Count != 0)
            {
                int temp;
                var firstChar = max.Dequeue();
                temp = firstChar + flag;
                flag = 0;

                if (min.Count != 0)
                {
                    var secondChar = min.Dequeue();
                    temp += secondChar;
                }

                if (temp <= 9)
                {
                    result.Enqueue(temp);
                }
                else
                {
                    result.Enqueue(temp % 10);
                    flag = temp / 10;
                }
            }

            if (flag != 0)
            {
                result.Enqueue(flag);
            }


            //var arrayResult = result. ToArray();

            var listNode = new ListNode();
            while (result.Count != 0)
            {
                listNode.val = result.Dequeue();
                listNode.next = new ListNode();
                listNode = listNode.next;
            }


            return new []{1};
        }
    }
}