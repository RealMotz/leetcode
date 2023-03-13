namespace code.Algorithms
{
    using System.Collections.Generic;
    using code.DataStructures;

    public class Recursion
    {
        // Excercise # 1
        public void ReverseString(char[] s)
        {
            ReverseStrHelper(s, 0);
        }

        private void ReverseStrHelper(char[] s, int index)
        {
            if (index >= (s.Length - index)) return;

            char c = s[index];
            s[index] = s[(s.Length - 1) - index];
            s[(s.Length - 1) - index] = c;
            ReverseStrHelper(s, index + 1);
        }

        // Excercise # 2
        public ListNode SwapPairs(ListNode head)
        {
            if (head == null) return head;
            if (head.next == null) return head;

            ListNode newHead = head.next;
            head.next = newHead.next;
            newHead.next = head;
            newHead.next.next = SwapPairs(newHead.next.next);
            return newHead;
        }

        // Excercise # 3
        public ListNode ReverseList(ListNode head)
        {
            ListNode newHead = head;
            ReverseListHelper(head, ref newHead);
            return newHead;
        }

        private ListNode ReverseListHelper(ListNode head, ref ListNode result)
        {
            if (head == null) return head;
            if (head.next == null)
            {
                result = head;
                return head;
            }

            ListNode node = ReverseListHelper(head.next, ref result);
            node.next = head;
            head.next = null;
            return head;
        }

        private TreeNode SearchBST(TreeNode root, int val)
        {
            if (root == null) return null;
            if (root.val == val) return root;

            var left = SearchBST(root.left, val);
            if (left != null) return left;

            var right = SearchBST(root.right, val);
            return right;
        }

        public IList<int> PascalTriangleRow(int rowIndex)
        {
            List<int> result = new List<int>();
            Dictionary<string, int> memo = new Dictionary<string, int>();

            for (int i = 0; i < rowIndex + 1; i++)
            {
                result.Add(CalculateRowNumbers(rowIndex, i, memo));
            }

            return result.ToArray();
        }

        public int CalculateRowNumbers(int i, int j, Dictionary<string, int> memo)
        {
            if (i == 0 || j == 0) return 1;
            if (j == i) return 1;
            if(memo.ContainsKey($"{i}{j}")) return memo[$"{i}{j}"];

            int result = CalculateRowNumbers(i - 1, j - 1, memo) + CalculateRowNumbers(i - 1, j, memo);
            memo[$"{i}{j}"] = result;
            return result;
        }
    }
}