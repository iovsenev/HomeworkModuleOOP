using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HomeworkModuleOOP;

namespace HomeworkModuleOOP
{
    public static class Creator
    {
        public static void CreateUser(UserData user)
        {
            PrintTextWithColor("===== Введите свои данные =====\n");
            PrintTextWithColor("Введите ваше имя: ");
            user.FirstName = Console.ReadLine();
            PrintTextWithColor("Введите фамилию: ");
            user.LastName = Console.ReadLine();
            PrintTextWithColor("Введите ваш email формата ***@***.***: ");
            user.Email = Console.ReadLine();
            PrintTextWithColor("Введите ваш телефон (11 цифр): ");
            user.PhooneNumber = Console.ReadLine();
            PrintTextWithColor($"\n====== Ваши данные: ======\n", ConsoleColor.Yellow);
            PrintTextWithColor($"{user.ToString()}\n", ConsoleColor.Yellow);
        }
        
        public static void CreateDeliveryList(DeliveryList<PointDelivery> points, DeliveryList<ShopDelivery> shops)
        {

            List<string> cityes = GetSomething("Город", 4);
            List<string> streets = GetSomething("Улица", 8);
            Random random = new Random();
            foreach (string city in cityes)
            {
                var i = 1;
                foreach (string street in streets)
                {
                    var deliveryPoint = new PointDelivery(city, street, 
                        random.Next(100), $"Пункт выдачи {i}");
                    var deliveryShop = new ShopDelivery(city, street, 
                        random.Next(100), $"Магазин {i}");
                    i++;
                    points.Add(deliveryPoint);
                    shops.Add(deliveryShop);
                }
            }
        }

        public static void CreateProductOnSaleList(ProductsOnSale<Product> products)
        {
            int count = 10;
            var sweatersName = GetSomething("Свитер", count);
            var shoeName = GetSomething("Обувь", count);
            var descriptions = GetSomething("Обувь", count);
            Random random = new Random();
            for (int i = 0; i < count; i++)
            {
                var sweater = new Sweaters(sweatersName[i], random.Next(1000, 5000), descriptions[i]);
                var shoes = new Shoes(shoeName[i], random.Next(1000, 5000), shoeName[i]);
                products.Add(sweater);
                products.Add(shoes);
            }
        }

        private static List<string> GetSomething(string text, int count)
        {
            var cityes = new List<string>();
            for (int i = 0; i < count; i++)
                cityes.Add(text + " " + (i + 1));
            return cityes;
        }

        public static void PrintTextWithColor(string text, ConsoleColor color = ConsoleColor.Green)
        {
            ConsoleColor defaultColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = defaultColor;
        }
    }
}
