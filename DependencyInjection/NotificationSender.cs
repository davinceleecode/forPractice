using System;
using System.Collections.Generic;
using System.Text;

namespace forPractice.DependencyInjection
{
    public class NotificationSender
    {
        private readonly INotificationService _notificationService;

        public NotificationSender(INotificationService notificationService)
        {
            this._notificationService = notificationService;
        }
        public void NotifyUser(string message)
        {
            this._notificationService.SendMessage(message);
        }
    }
}
