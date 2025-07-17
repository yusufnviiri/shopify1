using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
   public  class ShopItem
    {
        [Column("ShopItemId")]
        public int ShopItemId { get; set; }
        [Required(ErrorMessage = "name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? ShopItemName { get; set; }
        [Required(ErrorMessage = "is a required field.")]
        [MaxLength(500, ErrorMessage = "Maximum length for the ShopItemDescription is 500 characters")]
        public string? ShopItemDescription { get; set; }

        [ForeignKey("RoomId")]
        public int RoomId { get; set; }
        public Room? Room { get; set; }


    }
}
