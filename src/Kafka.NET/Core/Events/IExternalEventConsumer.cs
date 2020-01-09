using System.Threading;
using System.Threading.Tasks;

namespace Kafka.NET.Core.Events
{
    public interface IExternalEventConsumer
    {
        Task StartAsync(CancellationToken cancellationToken);
    }
}
