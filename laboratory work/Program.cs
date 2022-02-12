using System;

namespace laboratory_work
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Нажмите Enter для продолжения...\nИли другую,любую, кнопку для закрытия ");
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                    Text();
                else
                    break;
            }
        }

        public static void Text()
        {
            try
            {
                Console.WriteLine("Введите число A: ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите число B: ");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Результат: ряд чисел от A = {0} до B = {1}:", a, b);
                Count(a, b);

            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, попробуйте ввести число\n");
            }
        }

        public static void Count(int x, int y)
        {
            if (x < y)
            {
                Count(x, y - 1);
                Console.WriteLine(y + " ");
            }

            if (x > y)
            {
                Count(x, y + 1);
                Console.WriteLine(y + " ");
            } 
        }
        
    }
    
}
