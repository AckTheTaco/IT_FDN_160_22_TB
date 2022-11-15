using System;
class Test
{
    static void Main()
    {
        int iX;
        int iY;

        iX = 15321;
        while (iX != 0)
        {
            iY = iX % 10;
            Console.Write(iY);
            iX /= 10;
        }
        Console.WriteLine();
    }
}