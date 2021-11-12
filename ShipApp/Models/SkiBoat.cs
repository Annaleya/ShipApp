using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipApp.Models
{
    class SkiBoat : AbstractShip
    {
        internal override void BlowHorn(string blowHorn)
        {
            Console.WriteLine("Beep!");
        }
        internal override void MoveShip(string moveShip)
        {
            Console.WriteLine("Starting onboard motor!");
            base.MoveShip(moveShip);
        }
        internal override void StopShip(string stopShip)
        {
            Console.WriteLine("Stopping onboard motor!");
            base.StopShip(stopShip);
        }
    }
}
