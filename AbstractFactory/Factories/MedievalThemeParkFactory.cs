using AbstractFactory.Products;

namespace AbstractFactory.Factories;

/// <summary>
/// Concrete Factory - Medieval Theme
/// </summary>
public class MedievalThemeParkFactory : IThemeParkFactory
{
    public ICostume CreateCostume()
    {
        return new MedievalCostume();
    }

    public IRide CreateRide()
    {
        return new MedievalRide();
    }
}