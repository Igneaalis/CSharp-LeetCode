using System;

namespace Leetcode
{

    class Program
    {

        #region Leetcode

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode curNode;
                ListNode root = curNode = new ListNode();
                ListNode prevNode = null;
                ListNode _l1 = l1;
                ListNode _l2 = l2;

                //while (_l1 is not null || _l2 is not null)
                while (!(_l1 is null) || !(_l2 is null))
                {
                    _l1 ??= new ListNode();
                    _l2 ??= new ListNode();

                    int sum = curNode.val + _l1.val + _l2.val;
                    if (sum >= 10)
                    {
                        curNode.next = new ListNode() { val = 1 };
                    }
                    curNode.val = sum % 10;

                    _l1 = _l1.next;
                    _l2 = _l2.next;
                    prevNode = curNode;
                    curNode = curNode.next ??= new ListNode();
                }

                if (curNode.val == 0)
                {
                    prevNode.next = null;
                }

                return root;
            }
        }

        #endregion

        static void Main(string[] args)
        {
            Solution solution = new();
            var result = solution.AddTwoNumbers(
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9,
                                new ListNode(9,
                                    new ListNode(9,
                                        new ListNode(9))))))),
                new ListNode(9,
                    new ListNode(9,
                        new ListNode(9,
                            new ListNode(9))))
                );

            while (result is not null)
            {
                Console.WriteLine(result.val);
                result = result.next;
            }

            Console.ReadKey();
        }
    }
}
