using System;

namespace Lab01
{
    public struct CalculationResults
    {
        public double RealTime { get; set; }
        public (double, double, double, double) Coeffs { get; set; }
        public (double, double) Time { get; set; }
    }

    public class Calculator
    {
        public CalculationResults Calculate(IRandomizer reqRandomizer,
            IRandomizer servRandomizer, int n)
        {
            throw new NotImplementedException();
        }
    }
}
