using FactoryMethod.Factories.Notifications;
using FactoryMethod.Factories.vehicle;
using FactoryMethod.FactoryMethod;

Console.WriteLine("Welcome to the coder cave factory method example!");


Console.WriteLine("\n Please choose a ption system type: 1. Vehicle. 2. Notification.");
int optionOperator = int.Parse(Console.ReadLine()!);
if (optionOperator == 1)
{
    VehicleFactory vehicleFactory = null!;

    while (true)
    {
        Console.WriteLine("\n Please choose a vehicle type: 1. Car. 2. Motorcicle. 3. Bike. 4. QUIT.");
        int vehicleChoise = int.Parse(Console.ReadLine()!);
        switch (vehicleChoise)
        {
            case 1:
                vehicleFactory = new CarFactory();
                break;
            case 2:
                vehicleFactory = new MotorCicleFactory();
                break;
            case 3:
                vehicleFactory = new BikeFactory();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                break;

        }

        IVehicle vehicle = vehicleFactory.OrderVehicle();
        Console.WriteLine($"You have used a {vehicle.GetType().Name}");
    }

}
else
{
    NotificationFactory notificationFactory = null!;

    while (true)
    {
        Console.WriteLine("\n Please choose a notification type: 1. Email. 2. Push. 3. Sms. 4. QUIT.");
        int notificationChoise = int.Parse(Console.ReadLine()!);
        switch (notificationChoise)
        {
            case 1:
                notificationFactory = new EmailNotificationFactory();
                break;
            case 2:
                notificationFactory = new PushNotificationFactory();
                break;
            case 3:
                notificationFactory = new SmsNotificationFactory();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                break;

        }
        INotification notification = notificationFactory.CreateNotification();
        Console.WriteLine("\n Please enter the message");
        string message = Console.ReadLine();
        notification.Send(message);
    }
}
Console.WriteLine("Thanks you for using the notification system!");
Console.ReadKey();
