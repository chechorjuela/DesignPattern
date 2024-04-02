using FactoryMethod.FactoryMethod;
using FactoryMethod.Proructs.Notifications;

namespace FactoryMethod.Factories.Notifications
{
    public class SmsNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new SmsNotification();
        }
    }
}