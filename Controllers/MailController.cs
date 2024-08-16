using Email_Sender.Models;
using Email_Sender.Services;
using Microsoft.AspNetCore.Mvc;

namespace Email_Sender.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService _mailService;

        public MailController(IMailService mailService)
        {
            _mailService = mailService;
        }

        [HttpPost("Send")]
        public async Task<IActionResult> Send([FromForm] MailRequest request)
        {
            try
            {
                await _mailService.SendMailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
