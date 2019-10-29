using System.Linq;

namespace LiskovSubstitutionPrinciple
{
    public class EvenNumbersSumCalculator : Calculator
    {
        public EvenNumbersSumCalculator(int[] numbers) : base(numbers)
        {
        }

        public override int Calculate() => _numbers.Where(n => n % 2 == 0).Sum();
    }
}
