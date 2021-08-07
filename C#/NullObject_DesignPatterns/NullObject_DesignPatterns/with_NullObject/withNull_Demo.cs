using NullObject_DesignPatterns.shared;
using System;

namespace NullObject_DesignPatterns
{
    public class withNull_Demo
    {
        public static void Start()
        {
            AbstractUser customer1 = withoutNull_UserFactory.getUser("Rob");
            AbstractUser customer2 = withoutNull_UserFactory.getUser("Bob");
            AbstractUser customer3 = withoutNull_UserFactory.getUser("Jun");
            AbstractUser customer4 = withoutNull_UserFactory.getUser("Laura");
            AbstractUser customer5 = withoutNull_UserFactory.getUser("Ofek");

            Console.WriteLine("------------------Users:------------------");
            Console.WriteLine($"Customer1: {customer1.getName()}");
            Console.WriteLine($"Customer2: {customer2.getName()}");
            Console.WriteLine($"Customer3: {customer3.getName()}");
            Console.WriteLine($"Customer4: {customer4.getName()}");
            Console.WriteLine($"Customer5: {customer5.getName()}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
