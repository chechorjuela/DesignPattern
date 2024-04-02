using Singleton.EventLogger;
using Singleton.Singleton;

MySingleton singleton = MySingleton.GetInstance();
Console.WriteLine($"el nuevo guid es {singleton.id}");

EventLogger eventLogger = EventLogger.GetInstance();

eventLogger.LogEvent("Error event app1");
eventLogger.LogEvent("Error event app2");
eventLogger.LogEvent("Error event app3");
eventLogger.LogEvent("Error event app4");
eventLogger.LogEvent("Error event app5");
eventLogger.LogEvent("Error event app6");
eventLogger.LogEvent("Error event app7");

eventLogger.ShowLogs();
