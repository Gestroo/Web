using RestPanda;

namespace WebServer;

public class Program
{
    private static List<DateTime> _times = new();

    public static int GetTimes()
    {
        _times.Add(DateTime.Now);
        foreach (var time in _times.Where(time => (time - _times[^1]).Minutes >= 1))
        {
            _times.Remove(time);
        }
        return _times.Count;
    }

    public static void Main(string[] args)
    {
        using var server = new PandaServer(typeof(Program), new Uri("http://localhost:8888/"));
        server.Start();
        Console.WriteLine("Server started");
        Console.WriteLine("Press 'enter' to stop server...");
        Console.Read();
        server.Stop();
    }
}