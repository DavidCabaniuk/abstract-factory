namespace AbstractFactory.Products;

/// <summary>
/// Concrete Product - Medieval Ride
/// </summary>
public class MedievalRide : IRide
{
    public void Experience()
    {
        Console.WriteLine("Riding a horse.");
    }
}