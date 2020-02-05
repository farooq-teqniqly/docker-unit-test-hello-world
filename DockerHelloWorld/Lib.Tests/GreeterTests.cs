using Xunit;
using FluentAssertions;

namespace Lib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Greet_Returns_Name()
        {
            // Arrange
            var greeter = new Greeter();
            var expectedName = "farooq";

            // Act
            var actualName = greeter.Greet(expectedName);

            // Assert
            expectedName.Should().Be(actualName);
        }
    }
}
