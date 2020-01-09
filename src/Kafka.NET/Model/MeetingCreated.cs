using System;
using Kafka.NET.Core.Events;

namespace Kafka.NET.Model
{
    public class MeetingCreated : IExternalEvent
    {
        public Guid Id { get; }
        public string Name { get; }

        public MeetingCreated(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
