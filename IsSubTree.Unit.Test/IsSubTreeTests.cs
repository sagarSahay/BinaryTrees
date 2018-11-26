namespace IsSubTree.Unit.Test
{
    using Common;
    using FluentAssertions;
    using Xunit;

    public class IsSubTreeTests
    {
        [Fact]
        public void IsSubTree_GivenValidInput_FindsSubtreeIfPresent()
        {
            // Arrange 
            var s = new TreeNode(3)
            {
                left = new TreeNode(4)
                {
                    right = new TreeNode(1),
                    left = new TreeNode(2)
                    {
                        //right = new TreeNode(0)
                    }
                },
                right = new TreeNode(5)
            };
            
            var t = new TreeNode(4)
            {
                right = new TreeNode(2),
                left = new TreeNode(1)
            };
            var SUT = new Solution();

            // Act 
            var res = SUT.IsSubtree(s, t);
            
            // Assert
            res.Should().BeFalse();

        }
    }
}