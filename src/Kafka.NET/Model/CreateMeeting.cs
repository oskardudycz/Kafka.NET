using System;

namespace Kafka.NET.Model
{
    public class CreateMeeting
    {
        public Guid Id { get; }
        public string Name { get; }

        public CreateMeeting(Guid id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
