using AbstractFactory.Products;

namespace AbstractFactory.Factories;

/// <summary>
/// Concrete Factory - Futuristic Theme
/// </summary>
public class FuturisticThemeParkFactory : IThemeParkFactory
{
    public ICostume CreateCostume()
    {
        return new FuturisticCostume();
    }

    public IRide CreateRide()
    {
        return new FuturisticRide();
    }
}