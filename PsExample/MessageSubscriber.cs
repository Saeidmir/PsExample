namespace PsExample;

public class MessageSubscriber: IMessageSubscriber
{
    public void ReceiveMessage(string message)
    {
        Console.WriteLine($"Received message: {message}");
    }
}
