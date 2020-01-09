using System.Threading.Tasks;
using Kafka.NET.Core.Events;
using Kafka.NET.Model;
using Microsoft.AspNetCore.Mvc;

namespace Kafka.NET.Controllers
{
    [Route("api/[controller]")]
    public class MeetingsController: Controller
    {
        private readonly IExternalEventProducer externalEventProducer;

        public MeetingsController(IExternalEventProducer externalEventProducer)
        {
            this.externalEventProducer = externalEventProducer;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]CreateMeeting command)
        {
            await externalEventProducer.Publish(new MeetingCreated(command.Id, command.Name));
            return Created("api/Meetings", command.Id);
        }
    }
}
