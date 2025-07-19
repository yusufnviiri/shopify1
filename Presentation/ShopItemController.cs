using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;
using Shared.RequestFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
        public async Task<ActionResult> GetAllShopItems()
        {
            var items =await _service.ShopItemService.GetAllShopItemsService(false);
            return Ok(items);
        }
        [HttpGet("{id:int}", Name = "ShopItemById")]
        public async Task<ActionResult> GetShopItem(int id)
        {
            var room = await _service.ShopItemService.FindShopItemService(id, false);
            return Ok(room);
        }
        [HttpGet("{roomId:int}/{id:int}")]
        public async Task<ActionResult> GetShopItem(int id,int roomId)
        {
            var item =await _service.ShopItemService.FindRoomShopItemService(id,roomId, false);
            return Ok(item);
        }
        [HttpGet("{roomId:int}")]
        public async Task<ActionResult> GetRoomShopItems(int roomId , [FromQuery] ShopItemParameters shopItemParameters)
        {
            var pagedResult = await _service.ShopItemService.FindRoomShopItems(roomId, false, shopItemParameters);
                Response.Headers.Add("X-Pagination",JsonSerializer.Serialize(pagedResult.metaData));
            return Ok(pagedResult.shopItems);
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
