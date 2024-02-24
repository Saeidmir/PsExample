using System.Threading.Channels;

namespace PsExample;

public class MessageAccumulatorQueue : IAccumulatorQueue
{
    private readonly Channel<string> _queue;
    
    public MessageAccumulatorQueue()
    {
        var opts = new BoundedChannelOptions(100) { FullMode = BoundedChannelFullMode.Wait };
        _queue = Channel.CreateBounded<string>(opts);
    }

    public async ValueTask PushAsync(string Message)
    {
        
        await _queue.Writer.WriteAsync(Message);
    }

    public async ValueTask<string> PullAsync(CancellationToken cancellationToken)
    {
        var result = await _queue.Reader.ReadAsync(cancellationToken);
        return result;
    }

}
