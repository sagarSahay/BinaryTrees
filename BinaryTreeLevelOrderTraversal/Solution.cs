namespace BinaryTreeLevelOrderTraversal
{
    using System.Collections.Generic;
    using System.Data;
    using System.Runtime.CompilerServices;
    using Common;

    public class Solution
    {
        //Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();
        
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result =  Traverse(root, new Dictionary<int, List<int>>(), 0);
            var res = new List<IList<int>>();
            foreach (var resultKey in result.Keys)
            {
                res.Add(result[resultKey]);
            }

            return res;
        }

        private Dictionary<int, List<int>> Traverse(TreeNode root, Dictionary<int, List<int>> ls , int l)
        {
            if (root != null)
            {
                if (ls.ContainsKey(l))
                {
                    var list = ls[l];
                    list.Add(root.val);
                }
                else
                {
                    ls.Add(l, new List<int>(){root.val});
                    //ls[l]= new List<int>(){root.val};
                }

                if (root.left != null)
                {
                    ls = Traverse(root.left, ls, l + 1);
                }
                if (root.right != null)
                {
                    ls = Traverse(root.right, ls, l + 1);
                }
            }

            return ls;
        }
    }
}