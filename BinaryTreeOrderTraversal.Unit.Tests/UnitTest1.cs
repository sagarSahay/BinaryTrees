using System;
using Xunit;

namespace BinaryTreeOrderTraversal.Unit.Tests
{
    using BinaryTreeLevelOrderTraversal;
    using Common;
    using FluentAssertions;

    public class BinaryTreeOrderTraversalTests
    {
        [Fact]
        public void LevelOrder_GivenValidInput_ReturnsLevelOrderTraversal()
        {
            // Arrange 
            var treeNode = new TreeNode(3)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            var SUT = new Solution();
            
            // Act 
            var res = SUT.LevelOrder(treeNode);
            
            // Assert
            res.Count.Should().Be(3);
        }
    }
}