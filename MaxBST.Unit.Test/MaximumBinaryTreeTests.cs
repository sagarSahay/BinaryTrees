namespace MaxBST.Unit.Test
{
    using FluentAssertions;
    using MaximumBinaryTree;
    using Xunit;

    public class MaximumBinaryTreeTests
    {
        [Fact]
        public void FindMax_GivenValidInput_ReturnsMax()
        {
            // Arrange
            var SUT = new MaximumBinaryTree();

            // Act 
            var index = SUT.FindMax(new int[6] {3, 2, 1, 6, 0, 5}, 0, 6);

            // Assert 
            //max.Should().Be(6);
            index.Should().Be(3);
        }

        [Fact]
        public void ConstructMaxBinaryTree_WithValidInput_ConstructsTree()
        {
            // Arrange
            var SUT = new MaximumBinaryTree();

            // Act 
            var tn = SUT.ConstructMaximumBinaryTree(new int[6] {3, 2, 1, 6, 0, 5});

            // Assert 
            tn.Should().NotBeNull();
            tn.val.Should().Be(6);
            tn.left.Should().NotBeNull();
        }
    }
}