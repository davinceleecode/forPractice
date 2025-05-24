using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DesignPatterns.Behavioral_Patterns.Strategy
{
    public class Strategy
    {
        interface IMessage
        {
            void Send();
        }


        class SMS : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Sending SMS...");
            }
        }

        class Email : IMessage
        {
            public void Send()
            {
                Console.WriteLine("Sending SMS...");
            }
        }



        class Notify
        {
            public void SendMessage(IMessage message)
            {
                message.Send();
            }

        }



        class Implementation
        {
            public void SendMessage()
            {
                IMessage SMS = new SMS();
                IMessage Email = new Email();

                Notify notify = new Notify();
                notify.SendMessage(SMS);
                notify.SendMessage(Email);
            }
        }
    }
}
