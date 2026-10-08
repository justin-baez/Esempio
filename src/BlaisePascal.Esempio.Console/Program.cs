using BlaisePascal.Esempio.Domain;
using System;
using System.Collections.Generic;
using System.Text;

public class Program // this is a class
{
    //method of entry for the execution of the code
    public static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle("AB123CD");//it works only if we haven't defined a constructor with parameters, it works if we have defined a constructor with parameters
        //vehicle.LicencePlate = "AB123CD";     we can't beacause its private set
        string licence = vehicle.LicencePlate;

        
        Console.WriteLine(licence); 
        
    }

    
}
