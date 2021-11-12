using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipApp.Models
{
    internal abstract class AbstractShip
    {
        internal virtual void MoveShip(string moveShip)
        {
            Console.WriteLine("The ship has started to move.");
        }
        internal virtual void StopShip(string stopShip)
        {
            Console.WriteLine("The ship has stopped.");
        }
        internal abstract void BlowHorn(string blowHorn);
    }
}
