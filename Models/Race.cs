using RacingGame.Observer;
using RacingGame.Strategies.RacingGame.Strategies;
using RacingGame.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Models
{
    public class Race : ISubject
    {

        public int Laps { get; private set; }
        public string WeatherCondition { get; set; }

        private readonly List<IObserver> observers = new List<IObserver>();

        public Race(int laps, string weatherCondition)
        {
            Laps = laps;
            WeatherCondition = weatherCondition;
        }

        public void SetWeatherCondition(string weatherCondition)
        {
            WeatherCondition = weatherCondition;
        }


        public void StartRace(Car car, IFuelStrategy fuelStrategy, ITireStrategy tireStrategy)
        {
            Console.WriteLine("Гонка началась!");
            fuelStrategy.SwitchToAggressiveMode(car);
            tireStrategy.UseAggressiveTireStrategy(car);
        }

        public void AdjustForWeather(Car car)
        {
            if (WeatherCondition == "Rainy")
            {
                car.AdjustSpeed(-10);
                car.AdjustTireCondition(-20);
            }
            else if (WeatherCondition == "Sunny")
            {
                car.AdjustSpeed(10);
            }

            NotifyObservers($"Погодные условия изменились: {WeatherCondition}");
        }

        public void RegisterObserver(IObserver observer) => observers.Add(observer);

        public void RemoveObserver(IObserver observer) => observers.Remove(observer);

        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }
}
