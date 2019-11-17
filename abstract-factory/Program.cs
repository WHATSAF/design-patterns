using System;
using abstract_factory.Abstractions;
using abstract_factory.Factories;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory;
            IComputer computer;
            IMobilePhone mobilePhone;

            Console.WriteLine("-----------microsoft----------");

            factory = new MicrosoftFactory();
            computer = factory.CreateComputer();
            mobilePhone = factory.CreateMobilePhone();
            computer.Play();
            mobilePhone.Call();

            Console.WriteLine("------------apple--------------");

            factory = new AppleFactory();
            computer = factory.CreateComputer();
            mobilePhone = factory.CreateMobilePhone();
            computer.Play();
            mobilePhone.Call();

            Console.ReadLine();
        }
    }
}
