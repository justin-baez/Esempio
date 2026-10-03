using System;
using System.Collections.Generic;
using System.Text;

namespace BlaisePascal.Esempio.Domain
{
    public class Vehicle
    {
        private int _id;
        //private string _licencePlate;  lo mettiamo cosi se è solo di lettura
        private int _odometerKm;
        private double _dailyRate;
        private double _fuelLevelPercentage;

        
        public string LicencePlate { get; private set; }
        public int OdometerKm { get; private set; }
        public double DailyRate { get; private set; }
        public double FuelLevelPercentage { get; private set; }


        //unico metodo per cui non dobbiamo definire il tipo di ritorno è il costruttore, ha il nome della classe
        public Vehicle(string licencePlate)
        { 
            LicencePlate = licencePlate; //calls a private set
        }

        public Vehicle(string licencePlate, int id, int odometerKm, double dailyRate, double fuelLevelpercentage) { }






    }
}
