using Contracts.Service;
using Microsoft.AspNetCore.Mvc;
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
        public ActionResult GetAllShopItems()
        {
            var shopItems = _service.ShopItemService.GetAllShopItemsService(false);
            return Ok(shopItems);
        }
    }
}
