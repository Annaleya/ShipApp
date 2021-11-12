using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipApp.Models
{
    class SailBoat : AbstractShip
    {
        internal override void BlowHorn(string blowHorn)
        {
            Console.WriteLine("Toot!");
        }
        internal override void MoveShip(string moveShip)
        {
            Console.WriteLine("Raising sails!");
            base.MoveShip(moveShip);
        }
        internal override void StopShip(string stopShip)
        {
            Console.WriteLine("Lowering sails!");
            base.StopShip(stopShip);
        }
    }
}
