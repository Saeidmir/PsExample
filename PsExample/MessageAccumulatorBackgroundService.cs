using Microsoft.Extensions.Hosting;

namespace PsExample;

public class MessageAccumulatorBackgroundService : BackgroundService

{
    private readonly IAccumulatorQueue _queue;
    private readonly IMessageSubscriber _subscriber;
    public MessageAccumulatorBackgroundService(IAccumulatorQueue queue, IMessageSubscriber subscriber)
    {
        _queue = queue;
        _subscriber = subscriber;
    }
    
    
    protected async override Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {   
                var message = await _queue.PullAsync(stoppingToken);
                _subscriber.ReceiveMessage(message); // Call SubscriptionMessage when initializing

            }
            catch (Exception ex)
            {
                Console.WriteLine("An Error encountered {0} , inner Exception {1}",
                    ex.Message, ex.InnerException);
            }
        }
    }
    
    public override async Task StopAsync(CancellationToken cancellationToken)
    {
        Console.WriteLine("Stopping BackGround Service");
        await base.StopAsync(cancellationToken);
    }
}