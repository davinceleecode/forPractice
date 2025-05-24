using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class FactoryMethod
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
                Console.WriteLine("Sending Email...");
            }
        }




        class Notify
        {
            public void SendMessage(IMessage message)
            {
                message.Send();
            }
        }


        class Factory
        {
            public static IMessage CreateMessage(string type)
            {
                switch (type.ToLowerInvariant())
                {
                    case "sms":
                        {
                            return new SMS();
                        }

                    case "email":
                        {
                            return new Email();
                        }
                    default:
                        {
                            throw new ArgumentException("Invalid Type.");
                        }
                }
            }
        }


        class Implementation
        {


            public void SendMessage()
            {
                IMessage message1 = Factory.CreateMessage("sms");
                IMessage message2 = Factory.CreateMessage("email");

                Notify notify = new Notify();
                notify.SendMessage(message1);
                notify.SendMessage(message2);

            }
        }
    }
}
