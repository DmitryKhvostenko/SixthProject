using System;
namespace е64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = MyClass<int>.FactoryMethod();
            var word = MyClass<double>.FactoryMethod();
            Console.WriteLine("Значение: " + num + " Тип: " + num.GetType());
            Console.WriteLine("Значение: " + word + " Тип: " + word.GetType());
        }
    }
}