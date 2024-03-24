namespace Zadanie_2;

public class Container
{
    protected double mass { get; set; }
    protected int height { get; set; }
    /*
     * Weight in kilogram
     */
    public double ownWeight { get; set; }
    protected int depth { get; set; }
    public String serialId { set; get; }
    protected static int id = 0;
    protected double maxMass { get; set; }
    

    public Container(double mass, int height, int ownWeight, int depth, double maxMass)
    {
        this.mass = mass;
        this.height = height;
        this.ownWeight = ownWeight;
        this.depth = depth;
        this.maxMass = maxMass;
        id += 1;
    }

    protected virtual void EmptyCargo()
    {
        mass = 0;
        Console.WriteLine("Emptying the cargo");
    }

    protected virtual void LoadCargo(double addMass)
    {
        if ((maxMass - mass) < addMass)
        {
            throw new OverfillException("Container is overfill");
        }
        else
        {
            mass = mass + addMass;
        }
    }

    public double sumWeight()
    {
        return mass + ownWeight;
    }

    public override string ToString()
    {
        return $"Container {serialId}: Mass = {mass}, Height = {height}, OwnWeight = {ownWeight}, Depth = {depth}, MaxMass = {maxMass}";

    }
}