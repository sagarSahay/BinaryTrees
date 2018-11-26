namespace IsSubTree
{
    using Common;

    public class Solution
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            if (s == null)
            {
                return true;
            }

            if (t == null)
            {
                return false;
            }

            if (areIdentical(s, t))
            {
                return true;
            }

            return IsSubtree(s.left, t.left) || IsSubtree(s.right, t.right);

            //return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }

        public bool areIdentical(TreeNode s, TreeNode t)
        {
            if (s == null && t == null)
            {
                return true;
            }

            if (s == null || t == null)
            {
                return false;
            }

            return s.val == t.val
                   && areIdentical(s.left, t.left)
                   && areIdentical(s.right, t.right);
        }
    }
}