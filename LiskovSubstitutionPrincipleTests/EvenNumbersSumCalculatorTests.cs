using LiskovSubstitutionPrinciple;
using Xunit;

namespace LiskovSubstitutionPrincipleTests
{
    public class EvenNumbersSumCalculatorTests
    {
        [Fact]
        public void Should_Sum_Even_Numbers()
        {
            var values = new int[] { 10, 15, 2, 3 };
            var calculator = new EvenNumbersSumCalculator(values);
            Assert.Equal(10 + 2, calculator.Calculate());
        }

        [Fact]
        public void Should_Verify_Liskov()
        {
            var values = new int[] { 10, 15, 2, 3 };
            Calculator calculator = new EvenNumbersSumCalculator(values);
            Assert.Equal(10 + 2, calculator.Calculate());
        }
    }
}
