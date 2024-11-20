using RacingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Strategies
{
    namespace RacingGame.Strategies
    {
        public interface IFuelStrategy
        {
            void SwitchToEfficiencyMode(Car car);
            void SwitchToAggressiveMode(Car car);
        }
    }

}
