using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Proructs.Notifications
{
    public class EmailNotification : INotification
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email notification {message}");
        }
    }
}