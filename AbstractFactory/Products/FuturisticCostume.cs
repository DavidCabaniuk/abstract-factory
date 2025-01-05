namespace AbstractFactory.Products;

/// <summary>
/// Concrete Product - Futuristic Costume
/// </summary>
public class FuturisticCostume : ICostume
{
    public void Wear()
    {
        Console.WriteLine("Wearing a spacesuit.");
    }
}