namespace Zadanie_2;

public class LiquidsContainer: Container, IHazardNotifier
{
    private bool hasDangerCargo;
    public LiquidsContainer(double mass, int height, int ownWeight, int depth, double maxMass, bool hasDangerCargo) : base(mass, height, ownWeight, depth, maxMass)
    {
        this.hasDangerCargo = hasDangerCargo;
        serialId = "CON-L-"+Container.id;
        id++;
    }

    public void SendNotification()
    {
        Console.WriteLine("Container "+ serialId+" has danger situation");
    }

    protected override void LoadCargo(double addMass)
    {
        
        base.LoadCargo(addMass);
        if (hasDangerCargo)
        {
            if ((maxMass - mass) / 2 < mass)
                SendNotification();
        }
        else
        {
            if ((maxMass - mass) * (9/10) < mass)
                SendNotification();
        }
    }
}