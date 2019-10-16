using System;

namespace _6_InterfacesAndPolymorphism
{
    public class MailService
    {
        public void Send(MailService mail)
        {
            Console.WriteLine("Sending email...");
        }
    }
}
