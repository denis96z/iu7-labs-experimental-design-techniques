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
        public CalculationResults Calculate(IRandomizer reqRandomizer, IRandomizer servRandomizer, int n)
        {
            var reqMinGenerator = new ConstTimeGenerator(reqRandomizer.Min);
            var reqMaxGenerator = new ConstTimeGenerator(reqRandomizer.Min);
            var servMinGenerator = new ConstTimeGenerator(servRandomizer.Min);
            var servMaxGenerator = new ConstTimeGenerator(servRandomizer.Max);

            var t0 = new Model(reqMinGenerator, servMinGenerator).CountTime(n);
            var t1 = new Model(reqMinGenerator, servMaxGenerator).CountTime(n);
            var t2 = new Model(reqMaxGenerator, servMinGenerator).CountTime(n);
            var t3 = new Model(reqMaxGenerator, servMaxGenerator).CountTime(n);

            var t = new Model(new RandTimeGenerator(reqRandomizer),
                new RandTimeGenerator(servRandomizer)).CountTime(n);

            var b0 = (t0 + t1 + t2 + t3) / 4;
            var b1 = (-t0 + t1 + -t2 + t3) / 4;
            var b2 = (-t0 + -t1 + t2 + t3) / 4;
            var b3 = (t0 + -t1 + -t2 + t3) / 4;

            var λ = 1.0 / reqRandomizer.Avg;
            var μ = 1.0 / servRandomizer.Avg;

            var time1 = b0 + b1 * λ + b2 * μ;
            var time2 = time1 + b3 * λ * μ;

            return new CalculationResults
                {
                    RealTime = t,
                    Time = (time1, time2),
                    Coeffs = (b0, b1, b2, b3)
                };
        }
    }
}
