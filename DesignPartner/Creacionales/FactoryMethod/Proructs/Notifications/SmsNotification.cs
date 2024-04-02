using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Proructs.Notifications
{
    public class SmsNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Sms notification {message}");

        }

    }
}