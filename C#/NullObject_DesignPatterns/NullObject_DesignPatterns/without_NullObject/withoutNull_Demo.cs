using System;
using NullObject_DesignPatterns.shared;

namespace NullObject_DesignPatterns
{
    public class withoutNull_Demo
    {
        public static void Start()
        {

            // Will crash: [ Error - Null Exeption ]

            //AbstractUser customer1 = withoutNull_UserFactory.getUser("Rob");
            //AbstractUser customer2 = withoutNull_UserFactory.getUser("Bob");
            //AbstractUser customer3 = withoutNull_UserFactory.getUser("Jun");
            //AbstractUser customer4 = withoutNull_UserFactory.getUser("Laura");

            //Console.WriteLine("------------------Users:------------------");
            //Console.WriteLine($"Customer1: {customer1.getName()}");
            //Console.WriteLine($"Customer2: {customer2.getName()}");
            //Console.WriteLine($"Customer3: {customer3.getName()}");
            //Console.WriteLine($"Customer4: {customer4.getName()}");
            //Console.WriteLine("------------------------------------------");




            // We will have to do it this way instead:

            Console.WriteLine("------------------Users:------------------");
            AbstractUser customer1;
            if (withoutNull_UserFactory.getUser("Rob") != null)
            {
                customer1 = withoutNull_UserFactory.getUser("Rob");
                Console.WriteLine($"Customer1: {customer1.getName()}");
            }
            else
            {
                Console.WriteLine($"Customer1 is a guest");
            }

            AbstractUser customer2;
            if (withoutNull_UserFactory.getUser("Bob") != null)
            {
                customer2 = withoutNull_UserFactory.getUser("Bob");
                Console.WriteLine($"Customer2: {customer2.getName()}");
            }
            else
            {
                Console.WriteLine($"Customer2 is a guest");
            }

            AbstractUser customer3;
            if (withoutNull_UserFactory.getUser("Jun") != null)
            {
                customer3 = withoutNull_UserFactory.getUser("Jun");
                Console.WriteLine($"Customer3: {customer3.getName()}");
            }
            else
            {
                Console.WriteLine($"Customer3 is a guest");
            }

            AbstractUser customer4;
            if (withoutNull_UserFactory.getUser("Laura") != null)
            {
                customer4 = withoutNull_UserFactory.getUser("Laura");
                Console.WriteLine($"Customer4: {customer4.getName()}");
            }
            else
            {
                Console.WriteLine($"Customer4 is a guest");
            }

            Console.WriteLine("------------------------------------------");

            Console.ReadKey();
        }
    }
}

