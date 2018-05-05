using System;

namespace Lab01
{
    public interface IRandomizer
    {
        double GetRandom();

        double MathExp { get; }
        double Disp { get; }

        double Min { get; }
        double Max { get; }
        double Avg { get; }
    }

    public class BaseRandomizer : IRandomizer
    {
        private const uint A = 16070093;
        private const uint B = 453816693;
        private const uint M = 2147483648;

        private uint _y = 2451;

        public double GetRandom()
        {
            _y = (A * _y + B) % M;
            return (double)_y / M;
        }

        public double MathExp => 0.5;
        public double Disp => 1.0 / 12;

        public double Min => 0.0;
        public double Max => 1.0;
        public double Avg => 0.5;
    }

    public class ExpRandomizer : IRandomizer
    {
        private readonly double _λ;
        private readonly IRandomizer _randomizer = new BaseRandomizer();

        private const double MaxCorrectProb = 0.97;

        public ExpRandomizer(double λ)
        {
            _λ = λ > 0.0 ? λ : throw new ArgumentException("Ограничение: λ > 0.");

            MathExp = 1.0 / λ;
            Disp = 1.0 / Math.Pow(λ, 2);

            Min = 0.0;
            Avg = Math.Log(2) / λ;

            var k = Math.Sqrt(1.0 / MaxCorrectProb);
            Max = Avg + k * Disp;
        }

        public double GetRandom()
        {
            var r = _randomizer.GetRandom();
            return -Math.Log(r) / _λ;
        }

        public double MathExp { get; }
        public double Disp { get; }

        public double Min { get; }
        public double Max { get; }
        public double Avg { get; }
    }

    public class RayleighRandomizer : IRandomizer
    {
        private readonly double _σ;
        private readonly IRandomizer _randomizer = new BaseRandomizer();

        private const double MaxCorrectProb = 0.97;

        public RayleighRandomizer(double σ)
        {
            _σ = σ > 0.0 ? σ : throw new ArgumentException("Ограничение: σ > 0.");

            MathExp = σ * Math.Sqrt(Math.PI / 2);
            Disp = (2.0 - Math.PI / 2) * Math.Pow(σ, 2);

            Min = 0.0;
            Avg = σ * Math.Sqrt(Math.Log(4));

            var k = Math.Sqrt(1.0 / MaxCorrectProb);
            Max = Avg + k * Disp;
        }

        public double GetRandom()
        {
            var r = _randomizer.GetRandom();
            return Math.Sqrt(-2.0 * Math.Pow(_σ, 2) * Math.Log(1 - r));
        }

        public double MathExp { get; }
        public double Disp { get; }

        public double Min { get; }
        public double Max { get; }
        public double Avg { get; }
    }
}
