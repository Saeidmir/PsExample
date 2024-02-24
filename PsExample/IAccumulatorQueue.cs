using System.Diagnostics.CodeAnalysis;

namespace PsExample;

public interface IAccumulatorQueue
{
    /// <summary>
    /// This method is useful for inserting to a channel
    /// </summary>
    /// <param name="Message"></param>
    /// <returns></returns>
    public ValueTask PushAsync([NotNull] string Message);
    /// <summary>
    /// this is useful for pop up from a chanenl
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public ValueTask<string> PullAsync(CancellationToken cancellationToken);
}