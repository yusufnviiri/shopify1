using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{

    [Route("api/rooms")]
    [ApiController]
    public class RoomController : ControllerBase
    {

        private readonly IServiceManager _service;
        public RoomController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult GetAllRooms() {
            try
            {
                var rooms = _service.RoomService.GetAllRoomsService(false);
                return Ok(rooms);
            }
            catch
            {
                return StatusCode(500,"internal server error");
            }
        
        }


    }
}
