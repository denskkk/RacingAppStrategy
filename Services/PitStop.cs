using RacingGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Services
{
    public class PitStop
    {
        private string pitStopName;

        public void Refuel(Car car) => car.AdjustFuelLevel(100 - car.FuelLevel);

        public void Repair(Car car) => car.AdjustHealth(100 - car.Health);

        public void ChangeTires(Car car) => car.AdjustTireCondition(100 - car.TireCondition);

        public void Update(string message)
        {
            Console.WriteLine($"[{pitStopName}] Получено уведомление: {message}");
        }
    }
}
