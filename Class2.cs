using System;

namespace ConsoleApp6
{
    public class DerivedClass : BaseClass
    {

        public void lastname()
        {
            base.Lastname();
            Console.WriteLine("Введите имя Владельца счета: ");
            Console.Read();
        }
        public void number()
        {
            base.Number();
            Console.WriteLine("Введите номер счета: ");
            Console.Read();
        }
        public void percent()
        {
            base.Percent();
            Console.WriteLine("Введите процент: ");
            Console.Read();
        }
        public void totalMoney()
        {
            base.TotalMoney();
            Console.WriteLine("Введите баланс счета: ");
            Console.Read();
        }

    }
}







