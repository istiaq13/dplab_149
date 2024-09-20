using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dplab1
{
    public class NotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Notification: {message}");
        }
    }
}
