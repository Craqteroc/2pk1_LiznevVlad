using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Program
    {
        internal Program Program1
        {
            get => default;
            set
            {
            }
        }

        public static DeliveryRequest GetDeliveryInfo()
        {
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.requestTime = "1 минут";
            deliveryRequest.summ = 605.90;
            deliveryRequest.adr = "Улица Родимцева, дом 7, квартира 167";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo2()
        {
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.requestTime = "5 минут";
            deliveryRequest.summ = 877.20;
            deliveryRequest.adr = "Улица Дружбы, дом 1, квартира 16";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo3()
        {
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.requestTime = "15 минут";
            deliveryRequest.summ = 1949.59;
            deliveryRequest.adr = "Улица Джангильдина, дом 3, квартира 126";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo4()
        {
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.requestTime = "10 минут";
            deliveryRequest.summ = 940.50;
            deliveryRequest.adr = "Улица Чкалова, дом 3, квартира 154";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static void Print(DeliveryRequest deliveryRequest)
        {
            Console.WriteLine("Информация о доставке: ");
            Console.WriteLine($"Время ожидания: {deliveryRequest.requestTime}");
            Console.WriteLine($"Сумма: {deliveryRequest.summ}");
            Console.WriteLine($"Адрес: {deliveryRequest.adr}");
            Console.WriteLine($"Уникальный номер: {deliveryRequest.ID}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер заказа который вас интересует (от 1 до 4)");
            Double z = double.Parse(Console.ReadLine());
            if (z == 1)
            {
                var end = GetDeliveryInfo();
                Print(end);
            }
            if (z == 2)
            {
                var end2 = GetDeliveryInfo2();
                Print(end2);
            }
            if (z == 3)
            {
                var end3 = GetDeliveryInfo3();
                Print(end3);
            }
            if (z == 4)
            {
                var end4 = GetDeliveryInfo4();
                Print(end4);
            }

            Console.ReadKey();
        }
    }
}
