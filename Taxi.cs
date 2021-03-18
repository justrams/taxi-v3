#include <iostream>
using namespace std;

using System;

namespace TugasClassTaxi
{
    public class program
    {
        static void Main(string[] args)
        {

            // membuat objek Taxi
            Taxi taxi = new Taxi();

            // pengesetan nilai properties
            taxi.DriverName = "Joni";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}