using FactoryMethod.FactoryMethod;
using FactoryMethod.Proructs.Notifications;

namespace FactoryMethod.Factories.Notifications
{
    public class PushNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new PushNotification();
        }

    }
}