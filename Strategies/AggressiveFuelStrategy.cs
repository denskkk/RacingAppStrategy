using RacingGame.Models;
using RacingGame.Strategies.RacingGame.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Strategies
{
    public class AggressiveFuelStrategy : IFuelStrategy
    {
        public void SwitchToEfficiencyMode(Car car)
        {
            car.AdjustSpeed(-20);
            car.AdjustFuelLevel(-10);
            Console.WriteLine("Переключение на экономичный режим топлива.");
        }

        public void SwitchToAggressiveMode(Car car)
        {
            car.AdjustSpeed(20);
            car.AdjustFuelLevel(-10);
            Console.WriteLine("Переключение на агрессивный режим топлива.");
        }


    }
}
