using NetMQ;
using NetMQ.Sockets;

namespace ConnectingApps.ZeroMqWithNgrokDemo.Subscriber;

class Program
{
    static void Main(string[] args)
    {
        using var subSocket = new SubscriberSocket();
        // change this after the ngrok command
        subSocket.Connect("tcp://5.tcp.eu.ngrok.io:10837");

        // Subscribe to all messages (empty topic filter)
        subSocket.SubscribeToAnyTopic();
        Console.WriteLine("Subscriber connected");

        while (true)
        {
            // Receive and print each incoming frame
            string message = subSocket.ReceiveFrameString();
            Console.WriteLine($"[Subscriber] Received: {message}");
        }
    }
}