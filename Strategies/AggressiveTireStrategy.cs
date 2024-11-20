using RacingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Strategies
{
    public class AggressiveTireStrategy : ITireStrategy
    {
        public void UseAggressiveTireStrategy(Car car)
        {
            car.AdjustTireCondition(-15);
            Console.WriteLine("Используется агрессивная стратегия шин.");
        }

        public void UseConservativeTireStrategy(Car car)
        {
            car.AdjustTireCondition(-5);
            Console.WriteLine("Используется консервативная стратегия шин.");
        }
    }
}
