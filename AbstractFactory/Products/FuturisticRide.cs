namespace AbstractFactory.Products;

/// <summary>
/// Concrete Product - Futuristic Ride
/// </summary>
public class FuturisticRide : IRide
{
    public void Experience()
    {
        Console.WriteLine("Riding a spaceship.");
    }
}