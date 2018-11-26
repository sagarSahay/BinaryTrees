using System;

namespace BinaryTreeVerticalOrderTraversal
{
    using System.Collections.Generic;
    using System.Linq;
    using Common;

    public class Solution
    {
        public IList<IList<int>> VerticalOrder(TreeNode root)
        {
            var recordDict = new Dictionary<int,List<int>>();

            recordDict = Traverse(root, recordDict, 0);
            
            var res = new List<IList<int>>();
            foreach (var resultKey in recordDict.Keys)
            {
                res.Add(recordDict[resultKey]);
            }

            return res;
        }

        private Dictionary<int, List<int>> Traverse(TreeNode root, Dictionary<int, List<int>> recordDict, int level)
        {
            if (root != null)
            {
                if (root.left != null)
                {
                    recordDict = Traverse(root.left, recordDict, level+1);
                }

                if (root.right != null)
                {
                    recordDict = Traverse(root.right, recordDict, level+1);
                }
                
                if (!recordDict.ContainsKey(level))
                {
                    recordDict.Add(level, new List<int>(){root.val});
                }
                else
                {
                    var ls = recordDict[level];
                    ls.Add(root.val);
                }

            }

            return recordDict;
        }
    }
}