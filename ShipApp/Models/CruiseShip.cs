using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipApp.Models
{
    class CruiseShip : AbstractShip
    {
        internal override void BlowHorn(string blowHorn)
        {
            Console.WriteLine("WAAAAAAAAAAAAAAAAAAAOOOOOOOOOOOOOOOOOOOO!!!!!!!!!!!!!");
        }
        internal override void MoveShip(string moveShip)
        {
            Console.WriteLine("Starting all 112 engines!");
            base.MoveShip(moveShip);
        }
        internal override void StopShip(string stopShip)
        {
            Console.WriteLine("Stopping all 112 engines!");
            base.StopShip(stopShip);
        }
    }
}
