namespace FindTarget
{
    using System.Collections.Generic;
    using Common;

    public class FindTarget
    {
        public bool FindTarget1(TreeNode root, int k)
        {
            var ls = new List<int>();

            ls = Traverse(root, ls);

            if (ls.Count == 1)
            {
                return false;
            }

            for (int i = 0; i < ls.Count; i++)
            {
                var x = k - ls[i];
                for (int j = 0; j < ls.Count; j++)
                {
                    if (j != i)
                    {
                        if (ls[j] == k)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private List<int> Traverse(TreeNode node, List<int> ls)
        {
            
            if (node != null)
            {
                ls.Add(node.val);
                if (node.left != null)
                {
                    ls = Traverse(node.left, ls);
                }

                if (node.right != null)
                {
                    ls = Traverse(node.right, ls);
                }
            }

            return ls;
        }
    }
}