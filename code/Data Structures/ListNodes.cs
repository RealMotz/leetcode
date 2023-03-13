
namespace code.DataStructures
{
    using System.Collections.Generic;

    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next = null) {
            this.val = val;
            this.next = next;
        }

        public int[] GetNodeList() {
            List<int> list = new List<int>();

            ListNode node = this;
            while (node != null) {
                list.Add(node.val);
                node = node.next;
            }

            return list.ToArray();
        }

        public void PrintList() {
            ListNode node = this;
            while (node != null) {
                Console.WriteLine(node.val);
                node = node.next;
            }
        }
    }
}