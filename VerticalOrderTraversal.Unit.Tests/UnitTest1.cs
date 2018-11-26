namespace VerticalOrderTraversal.Unit.Tests
{
    using Common;
    using FluentAssertions;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public void VerticalTraversal_GivenValidInput_ReturnsVerticalOrderedLists()
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

            var SUT = new VerticalOrderTraversal.Solution();

            // Act 
            var res = SUT.VerticalOrder(treeNode);

            // Assert
            res.Should().NotBeNull();
        }
    }
}
