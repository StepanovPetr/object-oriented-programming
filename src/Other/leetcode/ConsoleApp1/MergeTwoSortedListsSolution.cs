using System;
using System.Collections;
using System.Collections.Generic;
using LeetCode.Common;
using LeetCode.Common.Factories;

namespace LeetCode
{
    public class MergeTwoSortedListsSolution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var list = new List<int>();

            for (ListNode item = list1; item != null; item = item.next)
            {
                list.Add(item.val);
            }

            for (ListNode item = list2; item != null; item = item.next)
            {
                list.Add(item.val);
            }

            list.Sort();
            //ListNode result = ListNodeFactory.FactoryMethod(list.ToArray());

            ListNode result = null;
            ListNode previous = null;
            foreach (var item in list)
            {
                ListNode node = new ListNode(item, null);
                if (result == null)
                {
                    result = node;
                    previous = node;
                }
                else
                {
                    previous.next = node;
                    previous = node;
                }
            }

            return result;
        }

        // You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order, and each of their nodes contains a single digit.Add the two numbers and return the sum as a linked list.
        // You may assume the two numbers do not contain any leading zero, except the number 0 itself.
        public int[] AddTwoNumbers(ListNode l1, ListNode l2)
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
                var firstChar =max.Dequeue();
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

            return result.ToArray();
        }
    }
}