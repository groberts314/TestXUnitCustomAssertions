using System;
using Xunit;

namespace TestXUnitCustomAssertions.Tests
{
    public class UnitTestFixture
    {
        [Fact]
        public void CustomAssertion_Works()
        {
            DateTime now1, now2;
            now1 = now2 = DateTime.Now;
            Assert.DateTimeMatchesWithinOneSecond(now2, now1);
        }
    }
}
