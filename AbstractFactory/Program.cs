// Futuristic Theme
using AbstractFactory.Factories;
using AbstractFactory;

IThemeParkFactory futuristicFactory = new FuturisticThemeParkFactory();
ThemePark futuristicPark = new ThemePark(futuristicFactory);
Console.WriteLine("Futuristic Theme Park Experience:");
futuristicPark.EnjoyExperience();

Console.WriteLine();

// Medieval Theme
IThemeParkFactory medievalFactory = new MedievalThemeParkFactory();
ThemePark medievalPark = new ThemePark(medievalFactory);
Console.WriteLine("Medieval Theme Park Experience:");
medievalPark.EnjoyExperience();
