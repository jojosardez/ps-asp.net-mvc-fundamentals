namespace MvcControllers.Infrastructure
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            System.Diagnostics.Debug.WriteLine(message);
        }
    }
}