using System;

namespace Lab1OP_Martakov
{
    class Program
    {
        static void Main(string[] args)
        {
            int grad = Convert.ToInt32(Console.ReadLine());
            int minutes = grad % 30 * 2;
            int hours = grad / 30;
            Console.WriteLine($"{hours}h {minutes}m");
        }
    }
}
