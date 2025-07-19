using AutoMapper;
using Entities.Models;
using saccoshop;
using Shared.Dtos;

namespace saccoshop
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {           //sorce,destination
            CreateMap<Room, RoomDto>();
            CreateMap<NewRoomDto, Room>();

        }
    }
}




    //CreateMap<CreateStudentDto, Student>().ForMember(k => k.DateOfBirth, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfBirth))).AfterMap((src, dest) => dest.SchoolFees=new SchoolFees(src.Fees)); 
    //CreateMap<CreateStudentDto, Student>().ForMember(k => k.DateOfBirth, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfBirth))).ForPath(m => m.SchoolFees.Balance, opt => opt.MapFrom(p => p.SchoolFees)).ForMember(k=>k.SchoolFees.Balance,opt=>opt.MapFrom(k=>k.SchoolFees));
    //CreateMap<CreateStudentDto, Student>().ForMember(k => k.DateOfBirth, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfBirth))).ForSourceMember(src=>src.Fees,opt=>opt.DoNotValidate());
    //CreateMap<CreateStudentDto, Student>().ForMember(k => k.DateOfBirth, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfBirth))).ForSourceMember(src => src.Fees, opt => opt.DoNotValidate());

  
    //CreateMap<CreateNoticeDto, Notice>().ForMember(k => k.DueDate, opt => opt.MapFrom(x => DateTime.Parse(x.DueDate)));
    //CreateMap<Notice, ShowNoticeDto>().ForCtorParam("DueDate",opt => opt.MapFrom(x => $"{x.DueDate.Day}/{x.DueDate.Month}/{x.DueDate.Year}"));
    //CreateMap<CreateAssetDto, Asset>().ForMember(k => k.DateOfPurchase, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfPurchase)));
    //CreateMap<Asset, ShowAssetDto>().ForCtorParam("DateOfPurchase", opt => opt.MapFrom(x => $"{x.DateOfPurchase.Value.Day}/{x.DateOfPurchase.Value.Month}/{x.DateOfPurchase.Value.Year}"));

    //CreateMap<Student, StudentOldData>().ForMember(k => k.StudentId, opt => opt.MapFrom(x => x.Id));
    //CreateMap<CreateStaffDto, Staff>().ForMember(k => k.DateOfBirth, opt => opt.MapFrom(x => DateTime.Parse(x.DateOfBirth)));
  

    //CreateMap<Student, ShowPersonDto>().ForCtorParam("BirthDate",opt => opt.MapFrom(x => $"{x.DateOfBirth.Value.Day}/{x.DateOfBirth.Value.Month}/{x.DateOfBirth.Value.Year}"));
    //CreateMap<Staff, ShowstaffDto>() .ForCtorParam("BirthDate",opt => opt.MapFrom(x => $"{x.DateOfBirth.Value.Day}/{x.DateOfBirth.Value.Month}/{x.DateOfBirth.Value.Year}"));
//CreateMap<Wage,ShowWagesDto>().ForSourceMember(src => src.Staff, opt => opt.DoNotValidate()); ;

