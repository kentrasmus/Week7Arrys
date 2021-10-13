using System;

namespace Week7Arrys
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm palub kasutajal valida, mida ta hommikusoogiks soob
            Console.WriteLine("Mida te hommikusoogiks tahate");

            string[] food = { "võileib juustuga", "banaan", "peekon", "muna", "Vegani salat", "Su ema" };

            food[4] = "viinerid";
            food[1] = "keefir";

            Console.WriteLine("Menüüs;");

            for(int i = 0; i < food.Length; i++)
            {
                Console.WriteLine(food[i]);
            }

            Console.WriteLine("Vali toit (sisesta number 1 - 6:");
            int userChoice = Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine($"Oled valinud {food[userChoice]}");

        }
    }
}
