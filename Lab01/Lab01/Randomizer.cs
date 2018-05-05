using System;

namespace Lab01
{
    public interface IRandomizer
    {
        double GetRandom();
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

        public double Min => 0.0;
        public double Max => 1.0;
        public double Avg => 0.5;
    }

    public class ExpRandomizer : IRandomizer
    {
        private readonly double _λ;
        private readonly IRandomizer _randomizer = new BaseRandomizer();

        public ExpRandomizer(double λ)
        {
            if (λ <= 0.0)
            {
                throw new ArgumentException("Ограничение: λ > 0.");
            }
            _λ = λ;
            Min = 0.0;
            Avg = Math.Log(2.0) / λ;
            Max = 2 * Avg;
        }

        public double GetRandom()
        {
            var r = _randomizer.GetRandom();
            return -Math.Log(r) / _λ;
        }

        public double Min { get; }
        public double Max { get; }
        public double Avg { get; }
    }

    public class RayleighRandomizer : IRandomizer
    {
        private readonly double _σ;
        private readonly IRandomizer _randomizer = new BaseRandomizer();

        public RayleighRandomizer(double σ)
        {
            if (σ <= 0.0)
            {
                throw new ArgumentException("Ограничение: σ > 0.");
            }
            _σ = σ;
            Min = 0.0;
            Avg = σ * Math.Sqrt(Math.Log(4.0));
            Max = 2 * Avg;
        }

        public double GetRandom()
        {
            var r = _randomizer.GetRandom();
            return Math.Sqrt(-2.0 * Math.Pow(_σ, 2) * Math.Log(1 - r));
        }

        public double Min { get; }
        public double Max { get; }
        public double Avg { get; }
    }
}
