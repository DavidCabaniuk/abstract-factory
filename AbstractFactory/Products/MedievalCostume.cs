namespace AbstractFactory.Products;

/// <summary>
/// Concrete Product - Medieval Costume
/// </summary>
public class MedievalCostume : ICostume
{
    public void Wear()
    {
        Console.WriteLine("Wearing a knight's armor.");
    }
}