using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Proructs.Notifications
{
    public class PushNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending push notification {message}");

        }

    }
}