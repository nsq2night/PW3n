namespace Пианино
{
    class Program
    {
        static int ocardion = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Piano4(key);
            }
        }

        static void Piano4(ConsoleKeyInfo key)
        {
            int[][] octavesArray = new int[5][];
            octavesArray[0] = new int[] { 65, 69, 73, 78, 82, 87, 92, 98, 104, 110, 116, 123 };
            octavesArray[1] = new int[] { 130, 138, 147, 155, 165, 175, 185, 196, 208, 220, 233, 247 };
            octavesArray[2] = new int[] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
            octavesArray[3] = new int[] { 523, 554, 587, 622, 659, 698, 740, 784, 831, 880, 932, 988 };
            octavesArray[4] = new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
            int n = -1;
            if (key.Key == ConsoleKey.Q)
            {
                n = 0;
            }
            else if (key.Key == ConsoleKey.W)
            {
                n = 1;
            }
            else if (key.Key == ConsoleKey.E)
            {
                n = 2;
            }
            else if (key.Key == ConsoleKey.R)
            {
                n = 3;
            }
            else if (key.Key == ConsoleKey.T)
            {
                n = 4;
            }
            else if (key.Key == ConsoleKey.Y)
            {
                n = 5;
            }
            else if (key.Key == ConsoleKey.U)
            {
                n = 6;
            }
            else if (key.Key == ConsoleKey.I)
            {
                n = 7;
            }
            else if (key.Key == ConsoleKey.O)
            {
                n = 8;
            }
            else if (key.Key == ConsoleKey.P)
            {
                n = 9;
            }
            else if (key.Key == ConsoleKey.Z)
            {
                n = 10;
            }
            else if (key.Key == ConsoleKey.X)
            {
                n = 11;
            }
            else if (key.Key == ConsoleKey.F1)
            {
                ocardion = 0;
            }
            else if (key.Key == ConsoleKey.F2)
            {
                ocardion = 1;
            }
            else if (key.Key == ConsoleKey.F3)
            {
                ocardion = 2;
            }
            else if (key.Key == ConsoleKey.F4)
            {
                ocardion = 3;
            }
        }
    }
}
