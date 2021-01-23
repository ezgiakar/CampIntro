using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ezgi Kar
            IndividualCustomer individualCustomer1 = new IndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNo = "12345";
            individualCustomer1.CustomerName = "Ezgi";
            individualCustomer1.CustomerSurname = "Akar";
            individualCustomer1.TcNo = "12345678910";

            //Kodlama.Io
            CorporateCustomer corporateCustomer1 = new CorporateCustomer();
            corporateCustomer1.Id = 2;
            corporateCustomer1.CustomerNo = "56789";
            corporateCustomer1.CompanyName = "Kodlama.Io";
            corporateCustomer1.TaxNo = "123456789";



            //Gerçek-Tüzel
            //base sınıf referans tutucudur.
            //SOLID L = inheritance
            // new varsa bellekte bir referans numarasıdır.
            // customer burada hem gerçek hem tüzel kişinin referansını tutuyor.
            //polimorfizm, çok çeşitlilik.
            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();


            //inherit edildiği için customerManagera iki customeri de verebiliyoruz.
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer1);
            customerManager.Add(corporateCustomer1);
        }
    }
}
