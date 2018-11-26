namespace MaximumBinaryTree
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Design.Serialization;
    using System.Linq;
    using Common;


    public class MaximumBinaryTree
    {
        public TreeNode ConstructMaximumBinaryTree(int[] nums)
        {
            //return ConstructMaximumBinaryTree(nums, 0 , nums.Length);

            if (nums.Length == 0) return null;
            
            Stack<TreeNode> stack = new Stack<TreeNode>();
            int i = 0;
            TreeNode n = null;
            while (i < nums.Length)
            {
                var node = new TreeNode(nums[i]);
                while (stack.Count > 0 && stack.Peek().val < node.val)
                {
                    TreeNode tn = stack.Pop();
                    node.left = tn;
                }

                if (stack.Count > 0)
                {
                    stack.Peek().right = node;
                }
                stack.Push(node);
                i++;
            }

            while (stack.Count >0)
            {
                n= stack.Pop();
            }

            return n;
            
        }

        public TreeNode ConstructMaximumBinaryTree1(int[] nums)
        {
            if (nums.Length == 1)
            {
                return new TreeNode(nums[0]);
            }

            var (max, index) = FindMax(nums);

            var tn = new TreeNode(max);

            var leftArray = new int[index];

            var rightArray = new int[nums.Length - (index + 1)];

            Array.Copy(nums, 0, leftArray, 0, index);

            Array.Copy(nums, index + 1, rightArray, 0, nums.Length - (index + 1));

            var left = leftArray.OrderByDescending(x => x).ToArray();

            var right = rightArray.OrderByDescending(x => x).ToArray();

            TreeNode leftRoot = null;
            for (int i = left.Length - 1; i >= 0; i--)
            {
                var currentNode = new TreeNode(left[i]);
                if(currentNode.val>left[i-1])
                currentNode.right = leftRoot;
                leftRoot = currentNode;
            }

            TreeNode rightRoot = null;
            for (int i = right.Length - 1; i >= 0; i--)
            {
                var currentNode = new TreeNode(right[i]);
                currentNode.left = rightRoot;
                rightRoot = currentNode;
            }

            tn.left = leftRoot;
            tn.right = rightRoot;
            return tn;
        }
        public (int val, int index) FindMax(int[] nums)
        {
            int max = 0;
            int index = -1;

            if (nums.Length == 1)
            {
                return (nums[0], 0);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                    index = i;
                }
            }

            return (max, index);
        }

        private TreeNode ConstructMaximumBinaryTree(int[] nums, int l, int r)
        {
            if (l == r)
            {
                return null;
            }

            var max_i = FindMax(nums, l, r);
            
            TreeNode root = new TreeNode(nums[max_i]);

            root.left = ConstructMaximumBinaryTree(nums, l, max_i );
            root.right = ConstructMaximumBinaryTree(nums, max_i + 1, r);

            return root;
        }


        public int  FindMax(int[] nums, int l , int r)
        {
            //int max = 0;
            int index = l;

            for (int i = l; i <r; i++)
            {
                if (nums[i] > nums[index])
                {
                    //max = nums[i];
                    index = i;
                }
            }

            return index;
        }
    }
}