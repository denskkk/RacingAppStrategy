using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
    public class Car
    {
        public int Speed { get; private set; }
        public double FuelLevel { get; private set; }
        public double TireCondition { get; private set; }
        public double Health { get; private set; }

        public Car(int speed, double fuelLevel, double tireCondition, double health)
        {
            Speed = speed;
            FuelLevel = fuelLevel;
            TireCondition = tireCondition;
            Health = health;
        }

        public void AdjustSpeed(int value) => Speed += value;

        public void AdjustFuelLevel(double value) => FuelLevel = Math.Max(0, FuelLevel + value);

        public void AdjustTireCondition(double condition) => TireCondition = Math.Max(0, TireCondition + condition);

        public void AdjustHealth(double health) => Health = Math.Max(0, Health + health);
    }
}
