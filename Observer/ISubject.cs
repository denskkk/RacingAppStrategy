using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Observer
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);   // Регистрация наблюдателя
        void RemoveObserver(IObserver observer);    // Удаление наблюдателя
        void NotifyObservers(string message);       // Уведомление всех наблюдателей
    }
}
