using FactoryMethod.FactoryMethod;

namespace FactoryMethod.Factories.Notifications
{
    public abstract class NotificationFactory
    {
        public abstract INotification CreateNotification();

    }
}