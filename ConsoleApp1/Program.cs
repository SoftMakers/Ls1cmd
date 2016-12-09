using System;

class Destruct
{
    private int x;

    public Destruct(int x)
    {
        this.X = x;
    }

    ~Destruct()
    {
        Console.WriteLine("Визов деструктора для обьекта №" + this.X);
    }

    public int X
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public static void Create (int i)
    {
        Destruct o = new Destruct(i);        
    }
}

class Demo
{
    public static void Main()
    {
        for (int i = 0; i < 1000000; i++)
        {
            Destruct.Create(i);
            System.Threading.Tasks.Task.Delay(200000); 
        }
    Console.Read();
    }
}







