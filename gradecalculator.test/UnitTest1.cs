using System;
using Moq;
using Xunit;
using FluentAssertions;
using FluentAssertions.Collections;

namespace gradecalculator.test
{
    public class UnitTest1
    {
        [Theory(DisplayName="คะแนนสามารถตัดเกรดได้สำเร็จ")]
        [InlineData(99,"A")]
        [InlineData(81,"A")]
        [InlineData(80,"B")]
        [InlineData(65,"C")]
        [InlineData(54,"D")]
        [InlineData(32,"F")]
        public void CalCulatorSuccess(int input, string expectedResult)
        {
            var cal = new Calculator();
            var x = cal.GradeCalculator(input);

            x.Should().Be(expectedResult);
        }

        [Theory(DisplayName="คะแนนสามารถตัดเกรดได้สำเร็จ")]
        [InlineData(105,"some thing wrong")]
        [InlineData(-10,"some thing wrong")]
        public void CalCulatorFail(int input, string expectedResult)
        {
            var cal = new Calculator();
            var x = cal.GradeCalculator(input);

            x.Should().Be(expectedResult);
        }



    }
}
