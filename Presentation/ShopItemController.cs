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
     [Route("api/shopItems")]
    [ApiController]
    public class ShopItemController : ControllerBase
    {

        private readonly IServiceManager _service;
        public ShopItemController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public ActionResult GetAllShopItems()
        {

            var items = _service.ShopItemService.GetAllShopItemsService(false);
            return Ok(items);

        }
        [HttpGet("{id:int}", Name = "ShopItemById")]
        public ActionResult GetShopItem(int id)
        {
            var room = _service.ShopItemService.FindShopItemService(id, false);
            return Ok(room);
        }
        [HttpGet("{roomId:int}/{id:int}")]
        public ActionResult GetShopItem(int id,int roomId)
        {
            var item = _service.ShopItemService.FindRoomShopItemService(id,roomId, false);
            return Ok(item);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom([FromBody] NewShopItemDto item)
        {
            if (item is null)
                return BadRequest("RoomDto object is null");
            var createdItem = await _service.ShopItemService.AddShopItem(item);
            return CreatedAtRoute("ShopItemById", new { id = createdItem.ShopItemId }, createdItem);
        }
    }
}
