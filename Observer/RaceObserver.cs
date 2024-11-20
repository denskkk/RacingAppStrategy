using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Observer
{
    public class RaceObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine($"[Уведомление]: {message}");
        }
    }
}
