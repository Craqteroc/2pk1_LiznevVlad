using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    public class DeliveryRequest
    {
        
        public Guid ID;
        private double requestTime;
        public double RequestTime
        { 
            get 
            { 
                return requestTime; 
            } 
            set 
            {
                DateTime date1 = new DateTime(2020, 7, 20);
                double b = date1.Year;
                if (value > b)
                {
                    requestTime = value;
                }
                } 

        }

        private double summ;
        public double Summ
        {
        get
            {
                return summ;
            }
            set
            {
                if(value > 1000 && value <10000)
                {
                    summ = value;
                }

            }
        }
        public string adr;

        
        


        internal Program Program
        {
            get => default;
            set
            {
            }
        }

        internal Program Program1
        {
            get => default;
            set
            {
            }
        }

        internal Program Program2
        {
            get => default;
            set
            {
            }
        }

        internal Program Program3
        {
            get => default;
            set
            {
            }
        }

        public void vos(DeliveryRequest deliveryRequest)
        {
            
            Console.WriteLine("Информация о доставке: ");
            var rejectedDelivery = new RejectedDelivery();
            Console.WriteLine($"Год заказа: {deliveryRequest.RequestTime}");
            Console.WriteLine($"Сумма: {deliveryRequest.Summ}");
            Console.WriteLine($"Адрес: {deliveryRequest.adr}");
            Console.WriteLine($"Уникальный номер: {deliveryRequest.ID}");
        }

    }


    class RejectedDelivery : DeliveryRequest
    {
        public string Reason { get; set; }

        public void vos1(RejectedDelivery rejectedDelivery)
        {
            
            DeliveryRequest rejectedDelivery1 = rejectedDelivery;
            rejectedDelivery1.vos(rejectedDelivery1);
            Console.WriteLine($"Отказ и причина отказа: {rejectedDelivery.Otkaz}");
        }

        private string otkaz;
        public string Otkaz
        {
            get
            {
                return otkaz;
            }
            set 
            {
                string t = "Да";
                if (value == t)
                {
                    otkaz = value;
                }
            }
        }
            
         
    }
}
