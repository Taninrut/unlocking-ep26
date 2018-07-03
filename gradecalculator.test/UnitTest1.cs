using System;
using Moq;
using Xunit;
using FluentAssertions;
using FluentAssertions.Collections;

namespace gradecalculator.test
{
    public class UnitTest1
    {
        [Theory(DisplayName="ทดสอบ")]
        [InlineData(99,"99")]
        public void Test1(int input, string expectedResult)
        {
            var cal = new Calculator();
            var x = cal.GetNumber(input);

            x.Should().Be(expectedResult);
        }
    }
}
