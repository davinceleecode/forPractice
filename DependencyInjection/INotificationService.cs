using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DependencyInjection
{
    public interface INotificationService
    {
        void SendMessage(string message);
    }
}
