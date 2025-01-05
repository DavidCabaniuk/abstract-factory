using AbstractFactory.Products;

namespace AbstractFactory.Factories;

/// <summary>
/// Abstract Factory
/// </summary>
public interface IThemeParkFactory
{
    ICostume CreateCostume();
    IRide CreateRide();
}
