using AutoMapper;
using Entities.Models;
using Shared.Dtos;

namespace saccoshop
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Room, RoomDto>();
        }
    }
}
