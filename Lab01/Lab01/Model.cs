using System;
using System.Collections.Generic;

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
        private const double DefaultTimeStep = 0.01;

        private readonly ITimeGenerator _reqTimeGenerator;
        private readonly ITimeGenerator _servTimeGenerator;

        public Model(ITimeGenerator generatorTimeGenerator,
            ITimeGenerator serviceTimeGenerator)
        {
            _reqTimeGenerator = generatorTimeGenerator ?? throw new ArgumentNullException();
            _servTimeGenerator = serviceTimeGenerator ?? throw new ArgumentNullException();
        }

        public double CountTime(int n, double dT = DefaultTimeStep)
        {
            var numRequests = 0;
            var currentTime = 0.0;

            var nextRecvTime = -0.01;
            var nextServTime = -0.01;

            var queue = new Queue<int>();
            for (; numRequests < n || queue.Count > 0; currentTime += dT)
            {
                // ReSharper disable once InvertIf
                if (nextRecvTime <= currentTime && numRequests < n)
                {
                    queue.Enqueue(numRequests++);
                    nextRecvTime = currentTime + _reqTimeGenerator.GetNextValue();
                }

                // ReSharper disable once InvertIf
                if (nextServTime <= currentTime && queue.Count > 0)
                {
                    queue.Dequeue();
                    nextServTime = currentTime + _servTimeGenerator.GetNextValue();
                }
            }

            return currentTime;
        }
    }
}
