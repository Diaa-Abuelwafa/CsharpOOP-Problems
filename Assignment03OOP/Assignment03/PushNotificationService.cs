using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine($"Hi {Recipient} This Push For You : {Message}");
        }
    }
}
