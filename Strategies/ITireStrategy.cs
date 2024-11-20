using RacingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Strategies
{
    public interface ITireStrategy
    {
        void UseAggressiveTireStrategy(Car car);
        void UseConservativeTireStrategy(Car car);
    }
}
