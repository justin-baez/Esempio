public class Program // this is a class
{
    //method of entry for the execution of the code
    public static void Main()
    {
        Console.WriteLine("Welcome in Easy Class 3E!");

        // we ask the user to insert his name, and we save it thanks to "ReadLibne" wich reads what the user put as an input
        Console.WriteLine("Insert client name");
        string nameClient = Console.ReadLine();

        Console.WriteLine("Insert shipping type");
        string shippingType = Console.ReadLine(); // to go around wrong answers we can use an enum class 

        Console.WriteLine("Insert quantity of packages");
        int numberBoughtPackages = int.Parse(Console.ReadLine());

        int priceShippingSingularPackage = 5; //declaration + initialization 
        priceShippingSingularPackage = 10; // reassignment 

        

        int totalCost = priceShippingSingularPackage * numberBoughtPackages; //calculation 

        //we want to write something specific so the user can understand what is happening
        //$ is used to concatenate the string with values, so everything inside {} will be counted as a value and printed

        Console.WriteLine($"Selected type of shipping: {shippingType}, and the total cost is: {totalCost}$");
        
    }
}
