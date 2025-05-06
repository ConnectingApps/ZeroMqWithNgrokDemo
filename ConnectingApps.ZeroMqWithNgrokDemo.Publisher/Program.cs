using NetMQ;
using NetMQ.Sockets;

namespace ConnectingApps.ZeroMqWithNgrokDemo.Publisher;

class Program
{
    static void Main(string[] args)
    {
        using var pubSocket = new PublisherSocket();
        pubSocket.Bind("tcp://*:5556");
        Console.WriteLine("Publisher started on tcp://*:5556");

        int counter = 0;
        while (true)
        {
            // Publish a simple message every second
            string message = $"Message {++counter}";
            pubSocket.SendFrame(message);
            Console.WriteLine($"[Publisher] Sent: {message}");
            Thread.Sleep(1000);
        }
    }
}