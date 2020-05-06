using System;

namespace facade
{
    public class BankCard
    {
        public static void ApplyCard()
        {
            Introducer.Guid();
            Recorder.RecordCustomer();
            Activator.ActivateCard();

            Console.WriteLine("thanks, card assigned.");
        }
    }
}
