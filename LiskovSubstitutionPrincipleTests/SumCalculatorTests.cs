using LiskovSubstitutionPrinciple;
using System;
using System.Linq;
using Xunit;

namespace LiskovSubstitutionPrincipleTests
{
    public class SumCalculatorTests
    {
        [Fact]
        public void Should_Not_Construct_When_Numbers_Is_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => new SumCalculator(null));
        }

        [Fact]
        public void Should_Construct()
        {
            var values = new int[] { 10, 15, 2, 3 };
            var calculator = new SumCalculator(values);
            Assert.NotNull(calculator);
        }

        [Fact]
        public void Should_Calculate()
        {
            var values = new int[] { 10, 15, 2, 3 };
            var sumCalculator = new SumCalculator(values);
            Assert.Equal(values.Sum(), sumCalculator.Calculate());
        }

        [Fact]
        public void Should_Verify_Liskov()
        {
            var values = new int[] { 10, 15, 2, 3 };
            Calculator calculator = new SumCalculator(values);
            Assert.Equal(values.Sum(), calculator.Calculate());
        }
    }
}
