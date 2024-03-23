namespace Zadanie_2;

public class Container
{
    private int mass { get; set; }
    private int height { get; set; }
    private int ownWeight { get; set; }
    private int depth { get; set; }
    private static String serialId { get; }
    private int maxMass { get; set; }
    

    public Container(int mass, int height, int ownWeight, int depth, int maxMass)
    {
        this.mass = mass;
        this.height = height;
        this.ownWeight = ownWeight;
        this.depth = depth;
        this.maxMass = maxMass;
    }

    void EmptyCargo()
    {
        Console.WriteLine("Emptying the cargo");
    }

    void LoadCargo(int addMass)
    {
        if ((maxMass - mass) < addMass)
        {
            throw new OverfillException("Container is overfill");
        }
    }
    
    
}