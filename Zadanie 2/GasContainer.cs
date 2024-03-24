namespace Zadanie_2;

public class GasContainer: Container, IHazardNotifier
{
    private double pressure;

    public GasContainer(double mass, int height, int ownWeight, int depth, double maxMass, double pressure) : base(mass, height, ownWeight, depth, maxMass)
    {
        this.pressure = pressure;
        serialId = "CON-G-"+Container.id;
    }

    protected override void EmptyCargo()
    {
        mass = mass * (5 / 100);
    }
    
    public void SendNotification()
    {
        Console.WriteLine("Container "+ serialId+" has danger situation");
    }
}