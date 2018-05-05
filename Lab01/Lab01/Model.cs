using System;

namespace Lab01
{
    public interface ITimeGenerator
    {
        double GetNextValue();
    }

    public class RandTimeGenerator : ITimeGenerator
    {
        private readonly IRandomizer _randomizer;

        public RandTimeGenerator(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public double GetNextValue()
        {
            return _randomizer.GetRandom();
        }
    }

    public class ConstTimeGenerator : ITimeGenerator
    {
        private readonly int _time;

        public ConstTimeGenerator(int time)
        {
            _time = time;
        }

        public double GetNextValue()
        {
            return _time;
        }
    }

    public class Model
    {
        private readonly ITimeGenerator _reqTimeGenerator;
        private readonly ITimeGenerator _servTimeGenerator;

        public Model(ITimeGenerator generatorTimeGenerator,
            ITimeGenerator serviceTimeGenerator)
        {
            _reqTimeGenerator = generatorTimeGenerator ?? throw new ArgumentNullException();
            _servTimeGenerator = serviceTimeGenerator ?? throw new ArgumentNullException();
        }

        public double CountTime(int n)
        {
            throw new NotImplementedException();
        }
    }
}
