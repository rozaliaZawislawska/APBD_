namespace Zadanie_2;

public class RefrigeratedContainer: Container
{
    protected String product;
    protected double temperature;

    public RefrigeratedContainer(double mass, int height, int ownWeight, int depth, double maxMass, string product, double temperature) : base(mass, height, ownWeight, depth, maxMass)
    {
        this.product = product;
        this.temperature = temperature;
        serialId = "CON-R-"+Container.id;
    }
}