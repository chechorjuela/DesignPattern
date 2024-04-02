using FactoryMethod.FactoryMethod;
using FactoryMethod.Proructs.Notifications;

namespace FactoryMethod.Factories.Notifications
{
    public class EmailNotificationFactory : NotificationFactory
    {
        public override INotification CreateNotification()
        {
            return new EmailNotification();
        }

    }
}