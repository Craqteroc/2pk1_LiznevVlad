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
            DateTime date2 = new DateTime(2019, 7, 20);
            double v = date2.Year;
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.RequestTime = v;
            deliveryRequest.Summ = 605.90;
            deliveryRequest.adr = "Улица Родимцева, дом 7, квартира 167";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo2()
        {
            DateTime date3 = new DateTime(2020, 7, 20);
            double x = date3.Year;
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.RequestTime = x;
            deliveryRequest.Summ = 877.20;
            deliveryRequest.adr = "Улица Дружбы, дом 1, квартира 16";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo3()
        {
            DateTime date4 = new DateTime(2021, 7, 20);
            double z = date4.Year;
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.RequestTime = z ;
            deliveryRequest.Summ = 1949.59;
            deliveryRequest.adr = "Улица Джангильдина, дом 3, квартира 126";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static DeliveryRequest GetDeliveryInfo4()
        {
            DateTime date5 = new DateTime(2022, 7, 20);
            double w = date5.Year;
            var deliveryRequest = new DeliveryRequest();
            deliveryRequest.RequestTime = w;
            deliveryRequest.Summ = 940.50;
            deliveryRequest.adr = "Улица Чкалова, дом 3, квартира 154";
            deliveryRequest.ID = Guid.NewGuid();

            return deliveryRequest;
        }

        public static void Print(DeliveryRequest deliveryRequest)
        {
            Console.WriteLine("Информация о доставке: ");
            Console.WriteLine($"Год заказа: {deliveryRequest.RequestTime}");
            Console.WriteLine($"Сумма: {deliveryRequest.Summ}");
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


        //static void Requst(DeliveryRequest deliveryRequest)
        //{
        //    if (deliveryRequest.Summ > 1000 && deliveryRequest.Summ < 10000)        Честно пытался сделать со статическими полями, но я не понимаю их суть :(
        //    {                                                                       Остальное сделал если я правильно понял суть
        //        Console.WriteLine(deliveryRequest.Summ + deliveryRequest.Summ);
        //    }
        //}
    }
}
