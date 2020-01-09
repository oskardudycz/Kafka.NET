using System.Threading.Tasks;

namespace Kafka.NET.Core.Events
{
    public interface IExternalEventProducer
    {
        Task Publish(IExternalEvent @event);
    }
}
