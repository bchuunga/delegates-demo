using DelegatesDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DelegatesDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoEventsController : ControllerBase
    {
        [HttpGet]
        public ActionResult RaiseEvent(string title)
        {
            var video = new Video() { Title = title };
            var videoEncorder = new VideoEncoder(); // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            videoEncorder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncorder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncorder.Encode(video);
            return Ok("Completed");
        }
    }
}
