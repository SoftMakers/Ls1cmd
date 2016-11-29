namespace Ls1
{
    class Ls1cmd
    {

        static void Main()
        {
            System.Console.ForegroundColor = System.ConsoleColor.Green;
            for (int j = 0; j < 500; j++)
            {
                for (int i = 0; i < 5000; i++)
                {
                    System.Console.Write(i);
                    System.Threading.Thread.Sleep(1);
                }
                //System.Console.Clear();
            }
            System.Console.Read();

        }
    }
}

