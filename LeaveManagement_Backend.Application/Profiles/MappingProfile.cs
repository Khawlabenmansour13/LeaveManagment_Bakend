using AutoMapper;
using LeaveManagement_Backend.Application.DTOs.LeaveAllocation;
using LeaveManagement_Backend.Application.DTOs.LeaveRequest;
using LeaveManagement_Backend.Application.DTOs.LeaveType;
using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using LeaveManagement_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Profiles
{
   public  class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
           
        }
    }
}
