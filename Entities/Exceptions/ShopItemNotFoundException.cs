using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Exceptions
{
     public sealed class ShopItemNotFoundException : NotFoundException
    {
        public ShopItemNotFoundException(int itemId)
        : base($"The item with id: {itemId} doesn't exist in the database.")
        {
        }
    }
   
}
