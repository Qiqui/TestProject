using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store onlineStore = new Store();

            Console.WriteLine("Здравствуйте. Выберите действие:");
            Console.WriteLine("1. Показать каталог продуктов?");
            Console.WriteLine("Выберите номер действия, которое хотите совершить.");
            int numberAction = Convert.ToInt32(Console.ReadLine());
            
            switch (numberAction)
            {
                case 1: onlineStore.ShowCatalog(); break;
                default:
                    Console.WriteLine("Выберите номер действия из списка");
                    break;
            }
            bool yes;
            do
            {
                Console.WriteLine("Хотите добавить продукт в корзину? Наберите Да или Нет.");
                yes = IsYes(Console.ReadLine());
                if (yes)
                {
                    onlineStore.ShowCatalog();
                    Console.WriteLine("Напишите номер продукта, которого нужно добавить в корзину");
                    int productNumber = Convert.ToInt32(Console.ReadLine());
                    onlineStore.AddToBasket(productNumber);
                }
            }
            while (yes);
            Console.WriteLine("Хотите посмотреть корзину? Наберите Да или Нет.");
            yes = IsYes(Console.ReadLine());
            if(yes)
            {
                onlineStore.ShowBasket();
            }
            Console.WriteLine("Хотите оформить заказ? Наберите Да или Нет.");
            yes = IsYes(Console.ReadLine());
            if (yes)
            {
               onlineStore.CreateOrder();
            }
        }
               static bool IsYes(string answer)
        {
            return answer.ToLower() == "да";
        }
    }
}
