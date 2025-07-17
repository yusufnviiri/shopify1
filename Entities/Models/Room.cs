using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Room
    {
        [Column("RoomId")]
        public int RoomId { get; set; }
        [Required(ErrorMessage = "name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string? RoomName { get; set; }
        [Required(ErrorMessage = "Owner is a required field.")]
        [MaxLength(100, ErrorMessage = "Maximum length is 60 characters")]
        public string? RoomOwner { get; set; }

        public ICollection<ShopItem>? ShopItems { get; set; }

    }
}
