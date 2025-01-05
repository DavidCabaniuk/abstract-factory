using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory;

/// <summary>
/// Client Code
/// </summary>
public class ThemePark
{
    private readonly ICostume _costume;
    private readonly IRide _ride;

    public ThemePark(IThemeParkFactory factory)
    {
        _costume = factory.CreateCostume();
        _ride = factory.CreateRide();
    }

    public void EnjoyExperience()
    {
        _costume.Wear();
        _ride.Experience();
    }
}
