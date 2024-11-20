using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingGame.Observer
{
    public interface IObserver
    {
        void Update(string message);  // Реакция на уведомление
    }
}
