using Xunit;

namespace UnitTests.Api
{
    public class HelloWorldController
    {
        [Fact]
        public void PassingTest()
        {
            Assert.True(true, "This is a tast");
        }
    }
}
