namespace Пианино
{
    internal class Program
    {

        static void Main(string[] args)
        {
            static void F1()
            {
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    int[] massive = new[] {65, 69, 73, 77, 82, 87, 92, 98, 103, 110, 116, 123};
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Beep(massive[0], 120);
                    }
                    if (key.Key == ConsoleKey.Q)
                    {
                        Console.Beep(massive[1], 120);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Beep(massive[2], 120);
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        Console.Beep(massive[3], 120);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Beep(massive[4], 120);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Beep(massive[5], 120);
                    }
                    if (key.Key == ConsoleKey.R)
                    {
                        Console.Beep(massive[6], 120);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Beep(massive[7], 120);
                    }
                    if (key.Key == ConsoleKey.T)
                    {
                        Console.Beep(massive[8], 120);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Beep(massive[9], 120);
                    }
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.Beep(massive[10], 120);
                    }
                    if (key.Key == ConsoleKey.J)
                    {
                        Console.Beep(massive[11], 120);
                    }

                    if (key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Актава 2");
                        F2();
                    }
                    if (key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Актава 3");
                        F3();
                    }
                } while (true); 
            }
            static void F2()
            {
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    int[] massive = new[] {261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493};
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Beep(massive[0], 120);
                    }
                    if (key.Key == ConsoleKey.Q)
                    {
                        Console.Beep(massive[1], 120);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Beep(massive[2], 120);
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        Console.Beep(massive[3], 120);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Beep(massive[4], 120);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Beep(massive[5], 120);
                    }
                    if (key.Key == ConsoleKey.R)
                    {
                        Console.Beep(massive[6], 120);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Beep(massive[7], 120);
                    }
                    if (key.Key == ConsoleKey.T)
                    {
                        Console.Beep(massive[8], 120);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Beep(massive[9], 120);
                    }
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.Beep(massive[10], 120);
                    }
                    if (key.Key == ConsoleKey.J)
                    {
                        Console.Beep(massive[11], 120);
                    }

                    if (key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Актава 1");
                        F1();
                    }
                    if (key.Key == ConsoleKey.F3)
                    {
                        Console.WriteLine("Актава 3");
                        F3();
                    }
                } while (true);
            }
            static void F3()
            {
                do
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    int[] massive = new[] {1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976};
                    if (key.Key == ConsoleKey.A)
                    {
                        Console.Beep(massive[0], 120);
                    }
                    if (key.Key == ConsoleKey.Q)
                    {
                        Console.Beep(massive[1], 120);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        Console.Beep(massive[2], 120);
                    }
                    if (key.Key == ConsoleKey.W)
                    {
                        Console.Beep(massive[3], 120);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        Console.Beep(massive[4], 120);
                    }
                    if (key.Key == ConsoleKey.F)
                    {
                        Console.Beep(massive[5], 120);
                    }
                    if (key.Key == ConsoleKey.R)
                    {
                        Console.Beep(massive[6], 120);
                    }
                    if (key.Key == ConsoleKey.G)
                    {
                        Console.Beep(massive[7], 120);
                    }
                    if (key.Key == ConsoleKey.T)
                    {
                        Console.Beep(massive[8], 120);
                    }
                    if (key.Key == ConsoleKey.H)
                    {
                        Console.Beep(massive[9], 120);
                    }
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.Beep(massive[10], 120);
                    }
                    if (key.Key == ConsoleKey.J)
                    {
                        Console.Beep(massive[11], 120);
                    }

                    if (key.Key == ConsoleKey.F1)
                    {
                        Console.WriteLine("Актава 1");
                        F1();
                    }
                    if (key.Key == ConsoleKey.F2)
                    {
                        Console.WriteLine("Актава 2");
                        F2();
                    }
                } while (true);
            }
            Console.WriteLine("Актавы: F1, F2, F3 ");
            ConsoleKeyInfo key = Console.ReadKey();
            do
            {
                if (key.Key == ConsoleKey.F1)
                {
                    Console.WriteLine("Актава 1");
                    F1();
                }
                if (key.Key == ConsoleKey.F2)
                {
                    Console.WriteLine("Актава 2");
                    F2();
                }
                if (key.Key == ConsoleKey.F3)
                {
                    Console.WriteLine("Актава 3");
                    F3();
                }
            } while (true);
        }
    }
}