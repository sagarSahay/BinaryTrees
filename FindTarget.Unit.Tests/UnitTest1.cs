namespace FindTarget.Unit.Tests
{
    using Common;
    using FluentAssertions;
    using Xunit;

    public class FindTargetTests
    {
        [Fact]
        public void FindTarget_ValidInput_ReturnsIfTargetExists()
        {
            // Arrange
            var treeNode = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(2),
                    right = new TreeNode(4)
                },
                right = new TreeNode(6)
                {
                    left = new TreeNode(7)
                }
            };
//            var treeNode = new TreeNode(2)
//            {
//                right = new TreeNode(3)
//            };
            
            var SUT = new FindTarget();
            
            // Act 

            var res = SUT.FindTarget1(treeNode, 6);
            
            // Assert
            res.Should().Be(true);
        }
    }
}