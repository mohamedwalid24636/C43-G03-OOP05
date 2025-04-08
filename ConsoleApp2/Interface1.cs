using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface INotificationService
    {
        public void SendNotification(string dist, string msg); 
                   
    }




    internal class EmailNotificationService : INotificationService
    {
        

        public void SendNotification(string dist, string msg)
        {
            Console.WriteLine($"your email message '{msg}' has been sent to {dist}");
        }
    };




    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string dist, string msg)
        {
            Console.WriteLine($"your sms message '{msg}' has been sent to {dist}");
        }
    };




    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string dist, string msg)
        {
            Console.WriteLine($"your push message '{msg}' has been sent to {dist}");
        }
    };














}
