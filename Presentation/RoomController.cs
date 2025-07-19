using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
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
        public ActionResult GetAllRooms()
        {

            var rooms = _service.RoomService.GetAllRoomsService(false);
            return Ok(rooms);

        }
        [HttpGet("{id:int}", Name = "RoomById")]
        public ActionResult GetRoom(int id)
        {
            var room = _service.RoomService.FindRoomsService(id, false);
            return Ok(room);
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] NewRoomDto room)
        {
            if (room is null)
                return BadRequest("RoomDto object is null");
            var createdRoom =await _service.RoomService.AddRoom(room);
            return CreatedAtRoute("RoomById", new { id = createdRoom.RoomId }, createdRoom);
        }
        [HttpGet("{roomId:int}/{id:int}")]
        public ActionResult GetShopItem(int id, int roomId)
        {
            var item = _service.ShopItemService.FindRoomShopItemService(id, roomId, false);
            return Ok(item);
        }

    }
}