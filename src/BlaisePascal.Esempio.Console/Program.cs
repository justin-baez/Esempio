public class Program // this is a class
{
    //method of entry for the execution of the code
    public static void Main()
    {
        Console.WriteLine("Welcome in Easy Class 3E!");

        int priceShippingSingularPackage = 5; //declaration + initialization 
        priceShippingSingularPackage = 10; // reassignment 

        int numberBoughtPackages = 2;

        string typeOfShipping = "Standard"; //declaration

        int totalCost = priceShippingSingularPackage * numberBoughtPackages; //calculation 

        //we want to write something specific so the user can understand what is happening
        //$ is used to concatenate the string with values, so everything inside {} will be counted as a value and printed

        Console.WriteLine($"Selected type of shipping: {typeOfShipping}, and the total cost is: {totalCost}$");
        
    }
}
