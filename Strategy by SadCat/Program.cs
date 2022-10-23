using Strategy_by_SadCat;

namespace Program
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                Digit digit = new Digit();
                digit.digit(result);
                Main();
            }
            else Console.WriteLine("Вы ввели не корректное число!!!");Main();  
        }
    }
}