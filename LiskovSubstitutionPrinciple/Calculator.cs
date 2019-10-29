using System;

namespace LiskovSubstitutionPrinciple
{
    public abstract class Calculator
    {
        protected readonly int[] _numbers;

        public Calculator(int[] numbers)
        {
            _numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public abstract int Calculate();
    }
}
