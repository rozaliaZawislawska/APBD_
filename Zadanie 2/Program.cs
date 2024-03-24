using Zadanie_2;

class Program
{
    public static void Main(string[] args)
    {
        List<Containership> listOfContainership = new List<Containership>();
        List<Container> listOfContainer = new List<Container>();
        bool exit = false;
        while (!exit)
        {
            if(listOfContainership.Count==0)
                Console.WriteLine("Lista kontenerowców: \n" + "brak");
            else
                Console.WriteLine("Lista kontenerowców: \n" + String.Join("\n", listOfContainership));
            if(listOfContainer.Count==0)
                Console.WriteLine("Lista kontenerów: \n" + "brak");
            else
                Console.WriteLine("Lista kontenerów: \n" + String.Join("\n", listOfContainer));
            int expression;
            Console.WriteLine("Możliwe akcje:\n1. Dodaj kontenerowiec\n2. Usun kontenerowiec\n3. Dodaj kontener\n4. Wyjście");
            expression= Convert.ToInt32(Console.ReadLine());
            switch (expression)
            {
                case 1:
                    Console.WriteLine("Podaj maksymalną prędkość:");
                    int maxSpeed = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Podaj maksymalną liczbę kontenerów:");
                    int maxContainerNum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Podaj maksymalną wagę:");
                    int maxWeight = Convert.ToInt32(Console.ReadLine());

                    Containership containership = new Containership(maxSpeed, maxContainerNum, maxWeight);
                    listOfContainership.Add(containership);
                    break;
                case 2:
                    Console.WriteLine("Podaj numer kontenerowca:");
                    listOfContainership.RemoveAt(Convert.ToInt32(Console.ReadLine())-1);
                    break;
                case 3:
                    int number;
                    do
                    {
                        Console.WriteLine("Podaj numer kontenerowca:");
                        number = Convert.ToInt32(Console.ReadLine()) - 1;
                    } while (number >= listOfContainership.Count);
                    Console.WriteLine("Podaj wagę:");
                    double mass = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj wysokość:");
                    int height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj wagę tylko konenera:");
                    int ownWeight = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj głębokość:");
                    int depth = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Podaj maksymalną wagę:");
                    double maxMass = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Podaj typ (G/L/R):");
                    char type = Convert.ToChar(Console.ReadLine());
                    switch (type)
                    {
                        case 'G':
                            Console.WriteLine("Podaj ciśnienie:");
                            double pressure = Convert.ToDouble(Console.ReadLine());
                            GasContainer gasContainer =
                                new GasContainer(mass, height, ownWeight, depth, maxMass, pressure);
                            listOfContainership[number].AddContainer(gasContainer);
                            listOfContainer.Add(gasContainer);
                            break;
                        case 'L':
                            Console.WriteLine("Czy przewozi niebezpieczny ładunek (true/false):");
                            bool hasDangerCargo = Convert.ToBoolean(Console.ReadLine());
                            LiquidsContainer liquidsContainer =
                                new LiquidsContainer(mass, height, ownWeight, depth, maxMass, hasDangerCargo);
                            listOfContainership[number].AddContainer(liquidsContainer);
                            listOfContainer.Add(liquidsContainer);
                            break;
                        case 'R':
                            Console.WriteLine("Podaj nazwę produktu: ");
                            string product = Console.ReadLine();
                            Console.WriteLine("Podaj temperaturę:");
                            int temerature = Convert.ToInt32(Console.ReadLine());
                            RefrigeratedContainer refrigeratedContainer =
                                new RefrigeratedContainer(mass, height, ownWeight, depth, maxMass, product, temerature);
                            listOfContainership[number].AddContainer(refrigeratedContainer);
                            listOfContainer.Add(refrigeratedContainer);
                            break;
                    }
                    break;
                case 4:
                    exit = true;
                    break;
            }
        }
    }
}