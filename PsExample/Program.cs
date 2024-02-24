// See https://aka.ms/new-console-template for more information

using PsExample;

var queue = new MessageAccumulatorQueue();

// Create a subscriber
var subscriber = new MessageSubscriber();

// Create the background service with the queue and subscriber
var backgroundService = new MessageAccumulatorBackgroundService(queue, subscriber);

// Start the background service
await backgroundService.StartAsync(CancellationToken.None);

// Simulate pushing messages to the queue
for (int i = 0; i < 5; i++)
{
    string message = $"Message {i}";
    await queue.PushAsync(message);
    Console.WriteLine($"Pushed message: {message}");
    await Task.Delay(1000); // Simulate some delay between pushing messages
}

Console.WriteLine("Press any key to stop the background service...");
Console.ReadKey();

// Stop the background service
await backgroundService.StopAsync(CancellationToken.None);