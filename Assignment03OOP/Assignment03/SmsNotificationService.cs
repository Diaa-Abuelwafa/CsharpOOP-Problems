using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string Recipient, string Message)
        {
            Console.WriteLine($"Hi {Recipient} This SMS For You : {Message}");
        }
    }
}
