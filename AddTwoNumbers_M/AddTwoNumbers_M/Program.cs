using System.Collections.Generic;

namespace AddTwoNumbers_M
{
    class Program
    {
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

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            //Form Number 1 & 2
            Queue<int> queue1 = GetNumberFromNode(l1);
            Queue<int> queue2 = GetNumberFromNode(l2);
            ListNode node = GetNodeFromNumber(queue1, queue2);
            return node;
        }

        private static ListNode GetNodeFromNumber(Queue<int> queue1, Queue<int> queue2)
        {
            var node = new ListNode();
            var sampleNode = node;
            int carrier = 0;
            //int[] nodeNumbers = finalnumber.ToString().Select(x => Convert.ToInt32(x) - 48).ToArray();
            while (true)
            {
                int nodeNumber = (queue1.Count != 0 ? queue1.Dequeue() : 0) + (queue2.Count != 0 ? queue2.Dequeue() : 0) + carrier;
                carrier = nodeNumber / 10;
                nodeNumber = nodeNumber % 10;
                sampleNode.val = nodeNumber;
                if (queue1.Count != 0 || queue2.Count != 0 || carrier != 0)
                {
                    sampleNode.next = new ListNode();
                    sampleNode = sampleNode.next;
                }
                else
                { break; }
            }
            return node;
        }

        private static Queue<int> GetNumberFromNode(ListNode node)
        {
            //double number = 0;
            //int power = 0;
            Queue<int> queue = new Queue<int>();
            while (node != null)
            {
                //number = number + (node.val * (double)Math.Pow(10, power));
                queue.Enqueue(node.val);
                node = node.next;
                //power++;
            }

            return queue;
        }

        static void Main(string[] args)
        {
            AddTwoNumbers(SetArrayToNode(new int[] { 9 }), SetArrayToNode(new int[] { 1, 9, 9, 9, 9, 9, 9, 9, 9, 9 })) ;
        }

        private static ListNode SetArrayToNode(int[] nodeNumbers)
        {
            var node = new ListNode();
            var sampleNode = node;
            int index = 1;
            foreach (int nodeNumber in nodeNumbers)
            {
                sampleNode.val = nodeNumber;
                if (nodeNumbers.Length != index)
                {
                    sampleNode.next = new ListNode();
                    sampleNode = sampleNode.next;
                }
                else
                    break;
                index++;
            }
            return node;
        }
    }
}
