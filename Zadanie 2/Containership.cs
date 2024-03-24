namespace Zadanie_2;

public class Containership
{
    private List<Container> listOfContainers { set; get; }
    private int maxSpeed;
    private int maxContainerNum;
    public int containerNum=0;
    /**
     * Weight in tons
     */
    private int maxWeight;

    private static int nextId=1;
    public int serialId;

    public Containership(int maxSpeed, int maxContainerNum, int maxWeight)
    {
        this.maxSpeed = maxSpeed;
        this.maxContainerNum = maxContainerNum;
        this.maxWeight = maxWeight;
        listOfContainers = new List<Container>();
        serialId = nextId;
        nextId += 1;
    }

    public void AddContainer(Container container)
    {
        containerNum += 1;
        if (maxContainerNum < containerNum)
        {
            containerNum -= 1;
            throw new OverfillException("Containership is overfill");
        }else if ((maxWeight*1000) < WeightAllContainers()+container.sumWeight())
        {
            throw new OverfillException("Containership is overfill");
        }
        else
        {
            listOfContainers.Add(container);
        }
    }

    private double WeightAllContainers()
    {
        double sum=0;
        foreach (Container container in listOfContainers)
        {
            sum += container.sumWeight();
        }

        return sum;
    }

    public void RemoveContainer(Container container)
    {
        containerNum -= 1;
        listOfContainers.Remove(container);
    }

    public void moveContainer(String oldSerialId, Containership newContainership)
    {
        for (var i = 0; i < listOfContainers.Count; i++)
        {
            if (listOfContainers[i].serialId == oldSerialId)
            {
                newContainership.AddContainer(listOfContainers[i]);
                listOfContainers.RemoveAt(i);
            }
        }
    }
    

    public void UnloadContainership()
    {
        containerNum = 0;
        listOfContainers = new List<Container>();
    }
    
    public void AddListContainers(List<Container> containers)
    {
        containerNum += containers.Count;
        if (maxContainerNum < containerNum)
        {
            containerNum -= containers.Count;
            throw new OverfillException("Containership is overfill");
        }
    }

    public override string ToString()
    { 
        return $"Statek  {serialId} : maxSpeed = {maxSpeed}, maxContainerNum = {maxContainerNum}, maxWeight = {maxWeight}";
    }
}