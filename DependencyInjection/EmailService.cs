using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DependencyInjection
{
    public class EmailService : INotificationService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"📧 Sending EMAIL :{message}");
        }
    }
}
