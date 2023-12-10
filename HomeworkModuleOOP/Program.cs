
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace HomeworkModuleOOP
{
    internal class Program
    {
        static UserData user = new UserData();
        static ProductsOnSale<Product> products = new ProductsOnSale<Product>();
        static DeliveryList<PointDelivery> deliveryToPoint = new DeliveryList<PointDelivery>();
        static DeliveryList<ShopDelivery> deliveryToShop = new DeliveryList<ShopDelivery>();
        static Cart<Product> cart = new Cart<Product>();

        static void Main(string[] args)
        {
            Console.WriteLine("----------- Приветствуем в нашем магазине ------------\n");
            Creator.CreateProductOnSaleList(products);
            Creator.CreateUser(user);
            Creator.CreateDeliveryList(deliveryToPoint, deliveryToShop);
            AddProductInCart();
            var delivery = GetDelivery();
            Order<Delivery> order = new Order<Delivery>(cart, user, delivery);
            Creator.PrintTextWithColor("\n===== Ваш Заказ: =====\n", ConsoleColor.Blue);
            Creator.PrintTextWithColor(order.ToString(), ConsoleColor.Magenta);
        }

        static void AddProductInCart()
        {
            Creator.PrintTextWithColor("Какой товар бы вы хотели добавить в корзину?\n");
            Creator.PrintTextWithColor("\n===== Вот наши товары ======\n", ConsoleColor.Blue);
            Creator.PrintTextWithColor(products.ToString(), ConsoleColor.Yellow);

            while (true)
            {
                Creator.PrintTextWithColor("\nВыберите номер товара или 0 если не хотите добавлять.\nВаш выбор: ");
                var chois = Console.ReadLine();
                if (Int32.TryParse(chois, out int id))
                {
                    if (id > 0 && id < products.Count)
                    {
                        cart.Add(products[id - 1]);
                    }
                    else if (id == 0)
                        break;
                    else 
                        Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
                }
                else Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
            }
        }

        private static Delivery GetDelivery()
        {
            Delivery delivery = null;
            while (true)
            {
                Creator.PrintTextWithColor("Доставить до пункта выдачи - 1, до магазина - 2, до квартиры - 3: ");
                var str = Console.ReadLine();
                if (str == "1")
                {
                    delivery = ChoisePointDelivery();
                    break;
                }
                else if (str == "2")
                {
                    delivery = ChoiseShopDelivery();
                    break;
                }
                else if (str == "3")
                {
                    delivery = GetHomeDelivery();
                    break;
                }
                else
                    Creator.PrintTextWithColor("Не верный ввод!", ConsoleColor.Red);
            }
            return delivery;
        }

        private static Delivery ChoisePointDelivery()
        {
            Creator.PrintTextWithColor("\n===== Вот наши пункты выдачи ======\n", ConsoleColor.Blue);
            Creator.PrintTextWithColor(deliveryToPoint.ToString(), ConsoleColor.Yellow);
            Creator.PrintTextWithColor("\nВыберите место доставки. " +
                "введите номер необходимого места доставки:\n");
            while (true)
            {
                Creator.PrintTextWithColor("\nВаш выбор: ");
                var chois = Console.ReadLine();
                if (Int32.TryParse(chois, out var id))
                {
                    if (id > 0 && id < deliveryToPoint.Count)
                    {
                        return deliveryToPoint[id - 1];
                    }
                    else
                        Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
                }
                else Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
            }
        }

        private static Delivery ChoiseShopDelivery()
        {
            Creator.PrintTextWithColor("\n===== Вот наши магазины ======\n", ConsoleColor.Blue);
            Creator.PrintTextWithColor(deliveryToShop.ToString(), ConsoleColor.Yellow);
            Creator.PrintTextWithColor("\nВыберите место доставки. " +
                "введите номер необходимого места доставки:\n");
            while (true)
            {
                Creator.PrintTextWithColor("\nВаш выбор: ");
                var chois = Console.ReadLine();
                if (Int32.TryParse(chois, out var id))
                {
                    if (id > 0 && id < deliveryToShop.Count)
                    {
                        return deliveryToShop[id - 1];
                    }
                    else
                        Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
                }
                else Creator.PrintTextWithColor("Не верный ввод\n", ConsoleColor.Red);
            }
        }

        static Delivery GetHomeDelivery()
        {
            string city;
            string street;
            int homeNomber;
            int flat;
            Creator.PrintTextWithColor("Введите свой город: ");
            city = Console.ReadLine();
            Creator.PrintTextWithColor("Введите свою улицу: ");
            street = Console.ReadLine();
            Creator.PrintTextWithColor("Введите номер дома: ");
            homeNomber = CheckNomeberEnter();
            Creator.PrintTextWithColor("Введите номер квартиры: ");
            flat = CheckNomeberEnter();
            return new HomeDelivery(city, street, homeNomber, flat);

        }

        private static int CheckNomeberEnter()
        {
            while (true)
            {

                Creator.PrintTextWithColor("Ваш ввод: ");
                var enter = Console.ReadLine();
                int Number;
                if (!Int32.TryParse(enter, out Number))
                    Creator.PrintTextWithColor("Не верный ввод!");
                else if (Number < 0)
                    Creator.PrintTextWithColor("Должен быть больше нуля");
                else return Number;
            }
        }
    }
}

