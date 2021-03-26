using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1?  30 olur çünkü değer tipidir.
           
            Console.WriteLine("sayi1: " + sayi1 + " " + sayi2);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;  //sayilar1'in referansı da sayilar2'nin referansı ile aynıdır. 101   102 sayilar1= 102 
            sayilar2[0] = 999;
            //sayilar1[0] ?  999 dur çünkü değer tipidir.

            //değer tiplerde değer atanır referans tiplerde adres atanır.
            //int,decimal,float,double,bool=değer tip
            //array,class,interface=referans tip
            //int, decimal, float, enum, boolean -->value types
            

            Console.WriteLine("Sayılar1[0]" + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Ali";

            person2 = person1;  // person1 refe no person2'e aktarılır. Değer eşitlemesi değil, adres eşitlemesi yapılır
            person1.FirstName = "Mert";

            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();
            customer.FirstName = "Ahmet";
            customer.CreditCardNumber = "1111111111111";
            Person person3 = customer;


            //Console.WriteLine(person3.FirstName);
            Console.WriteLine(((Customer)person3).CreditCardNumber);


            Employee employee = new Employee();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customer);
        }


        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Surname { get; set; }
        }
        
        class Customer : Person
        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }

        class ProjectManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}