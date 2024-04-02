namespace Singleton.EventLogger
{
    public class EventLogger
    {
        private static EventLogger _instance;
        private List<string> _eventLogs;

        private EventLogger()
        {
            _eventLogs = new List<string>();
        }

        public static EventLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EventLogger();
            }
            return _instance;
        }

        public void LogEvent(string EventMessage)
        {
            string timestamp = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fff");
            _eventLogs.Add($"{timestamp}: {EventMessage}");
        }

        public void ShowLogs()
        {
            foreach (string message in _eventLogs)
            {
                Console.WriteLine($"{message}");
            }
        }

    }
}