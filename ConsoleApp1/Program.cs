using System;

class Building
{
    public int Floors;
    public int Area;
    public int Occupants;
}

class BuildingDemo
{
    static void Main()
    {
        Building house1 = new Building();
        int AreaPP;

        house1.Occupants = 4;
        house1.Area = 2500;
        house1.Floors = 2;

        AreaPP = house1.Area / house1.Occupants;
        Console.WriteLine("Дом имеет:\n " +
                          house1.Floors +  " этажа\n " +
                          house1.Occupants + " жильца\n " +
                          house1.Area + " кв.метров общей площади, из них\n " +
                          AreaPP + " приходиться на одного человека.");                
        Console.Read();
    }
}



