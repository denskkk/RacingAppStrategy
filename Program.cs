using RacingGame.Models;
using RacingGame.Observer;
using RacingGame.Services;
using RacingGame.Strategies;
using RacingGame.Strategies.RacingGame.Strategies;
using System;

namespace RacingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створюємо автомобіль
            Car car = new Car(100, 100, 100, 100);

            // Створюємо гонку
            Race race = new Race(10, "Sunny");



            // Додаємо спостерігача
            RaceObserver observer = new RaceObserver();
            race.RegisterObserver(observer);

            // Стратегії
            IFuelStrategy aggressiveFuelStrategy = new AggressiveFuelStrategy();
            ITireStrategy aggressiveTireStrategy = new AggressiveTireStrategy();
            IFuelStrategy efficientFuelStrategy = new AggressiveFuelStrategy();
            ITireStrategy conservativeTireStrategy = new AggressiveTireStrategy();

            // Старт гонки
            Console.WriteLine("Гонка розпочалась!");
            race.NotifyObservers("Гонка розпочалась. Удачі!");

            for (int lap = 1; lap <= race.Laps; lap++)
            {
                Console.WriteLine($"\nКоло {lap}:");

                if (lap <= 3)
                {
                    Console.WriteLine("Агресивна стратегія на перших трьох колах.");
                    race.StartRace(car, aggressiveFuelStrategy, aggressiveTireStrategy);
                }
                else if (lap == 4)
                {
                    Console.WriteLine("Перехід на економну стратегію через зношення ресурсів.");
                    race.StartRace(car, efficientFuelStrategy, conservativeTireStrategy);
                }

                if (lap == 5)
                {
                    Console.WriteLine("Піт-стоп. Автомобіль заїжджає для дозаправки та заміни шин.");
                    PitStop pitStop = new PitStop();

                    pitStop.Refuel(car);
                    pitStop.ChangeTires(car);
                    pitStop.Repair(car);
                    race.NotifyObservers("Піт-стоп виконано успішно.");
                }

                // Обробка погодних умов
                if (lap == 6)
                {
                    race.SetWeatherCondition("Rainy");
                    Console.WriteLine("Почався дощ. Налаштування автомобіля адаптуються.");
                    race.AdjustForWeather(car);
                }

                // Вивід поточного стану автомобіля
                PrintCarStatus(car);

                // Повідомлення про завершення кола
                race.NotifyObservers($"Коло {lap} завершено. Поточний рівень палива: {car.FuelLevel}%, стан шин: {car.TireCondition}%.");
            }

            Console.WriteLine("\nГонка завершена. Вітаємо з фінішем!");
        }

        // Метод для відображення стану автомобіля
        static void PrintCarStatus(Car car)
        {
            Console.WriteLine($"Поточна швидкість: {car.Speed} км/год");
            Console.WriteLine($"Рівень палива: {car.FuelLevel}%");
            Console.WriteLine($"Стан шин: {car.TireCondition}%");
            Console.WriteLine($"Стан автомобіля: {car.Health}%");
        }
    }
}
