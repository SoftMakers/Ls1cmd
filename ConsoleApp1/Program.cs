using System;

class Building
{
    public Building (int f, int a, int o)
    {
        Floors = f;
        Area = a;
        Occupants = o;
    }

    public int Floors;
    public int Area;
    public int Occupants;

    public int AreaPerPerson()
    {
        return Area / Occupants;
    }

    public int MaxOccupants(int minArea)
    {
        return Area / minArea;
    }
}

class BuildingDemoMethods
{
    static void Main()
    {
        Building house1 = new Building(2,2500,4);
        Building office1 = new Building(3,4200,25);

        Console.WriteLine();
        Console.WriteLine(" Дом имеет:\n " +
                          house1.Floors + "  этажа\n " +
                          house1.Occupants + "  жильца\n " +
                          house1.Area + "  кв.метров общей площади, из них\n " +
                          house1.AreaPerPerson() + " приходиться на одного человека.");
        Console.WriteLine();

        Console.WriteLine(" Учреждение имеет:\n " +
                          office1.Floors + "  этажа\n " +
                          office1.Occupants + "  жильца\n " +
                          office1.Area + "  кв.метров общей площади, из них\n " +
                          office1.AreaPerPerson() + " приходиться на одного человека.");;
        Console.WriteLine();

        if ( house1.AreaPerPerson() > office1.AreaPerPerson() )
        {
            Console.WriteLine(" В доме больше места на каждого жильца чем в офисе.");
        }
        else Console.WriteLine(" В офисе больше места на каждого жильца чем в доме.");
        Console.WriteLine();

        Console.WriteLine(" При условии что минимум на одного человека 100 кв.м, количество свободних мест:");
        Console.WriteLine(" в доме - " + (house1.MaxOccupants(100)-house1.Occupants) );
        Console.WriteLine(" в офисе - " + (office1.MaxOccupants(100) - office1.Occupants));
        Console.Read();

    }
}



