using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using ShipApp.Models;

namespace ShipApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool gameOver = false;
            bool chooseShip = true;
            bool boatOrders = true;
            string boatChoice = "";

            while (gameOver == false)
            {
                Console.WriteLine("Exit the game at any time by typing 'stop' or 'end'.");
                Console.WriteLine("Press any key to continue");

                while (chooseShip)
                {
                    //Ask user what type of ship they are running
                    Console.WriteLine("What type of ship are you running?");
                    Console.WriteLine("1.Cruise Ship 2.Sail Boat 3.Ski Boat");
                    string userBoat = Console.ReadLine().ToLower();

                    if (userBoat == "1" || userBoat == "cruise ship")
                    {
                        boatChoice = "cruise ship";
                        chooseShip = false;
                        boatOrders = true;
                    }
                    else if (userBoat == "2" || userBoat == "sail boat")
                    {
                        boatChoice = "sail boat";
                        chooseShip = false;
                        boatOrders = true;
                    }
                    else if (userBoat == "3" || userBoat == "ski boat")
                    {
                        boatChoice = "ski boat";
                        chooseShip = false;
                        boatOrders = true;
                    }
                    else if (userBoat == "stop" || userBoat == "end")
                    {
                        chooseShip = false;
                        boatOrders = false;
                        gameOver = true;
                        Console.WriteLine("Press any key to exit");
                        Console.ReadKey();
                    }
                    Console.Clear();
                }
                while (boatOrders)
                {
                    Console.WriteLine("Change ship at any time by typing 'change' or 'change ship'");
                    Console.WriteLine("What is your command, Captain?");
                    Console.WriteLine("Move  Stop  Horn");
                    string userCommand = Console.ReadLine().ToLower();

                    
                    CruiseShip cruiseShip = new CruiseShip();
                    SailBoat sailBoat = new SailBoat();
                    SkiBoat skiBoat = new SkiBoat();
                    if (userCommand == "change" || userCommand == "change ship")
                    {
                        boatOrders = false;
                        chooseShip = true;
                        boatChoice = null;
                    }
                    else if (boatChoice == "cruise ship")
                    {
                        switch (userCommand)
                        {
                            case "move":
                                cruiseShip.MoveShip(userCommand);
                                break;
                            case "stop":
                                cruiseShip.StopShip(userCommand);
                                break;
                            case "horn":
                            case "blow horn":
                                cruiseShip.BlowHorn(userCommand);
                                break;
                        }
                    }
                    else if (boatChoice == "sail boat")
                    {
                        switch (userCommand)
                        {
                            case "move":
                                sailBoat.MoveShip(userCommand);
                                break;
                            case "stop":
                                sailBoat.StopShip(userCommand);
                                break;
                            case "horn":
                            case "blow horn":
                                sailBoat.BlowHorn(userCommand);
                                break;
                        }
                    }
                    else if (boatChoice == "ski boat")
                    {
                        switch (userCommand)
                        {
                            case "move":
                                skiBoat.MoveShip(userCommand);
                                break;
                            case "stop":
                                skiBoat.StopShip(userCommand);
                                break;
                            case "horn":
                            case "blow horn":
                                skiBoat.BlowHorn(userCommand);
                                break;
                        }
                    }


                }
            }
        }
    }
}
