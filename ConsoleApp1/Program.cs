using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Type testimony of counter with a fractional part here: ");
        var nt = Console.ReadLine();
        try
        {
            Convert.ToDouble(nt);
            Console.WriteLine("Var was initialize that {0}", nt.GetType());
            Console.WriteLine("{0:#.###} this is your testimory!", Convert.ToDouble(nt));
            Console.WriteLine("Price: 61.52 грн\\м.куб");
            Console.WriteLine("Total price: {0}", Convert.ToDouble(nt)*61.52);

        }
        catch { Console.WriteLine("Type only double!"); }        
        Console.Read();
    }
}



