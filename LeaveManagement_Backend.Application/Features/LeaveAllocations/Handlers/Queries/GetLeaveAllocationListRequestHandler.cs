﻿using AutoMapper;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using LeaveManagement_Backend.Application.DTOs.LeaveAllocation;
using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using LeaveManagement_Backend.Application.Features.LeaveAllocations.Requests.Queries;
using LeaveManagement_Backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;
       // private readonly IHttpContextAccessor _httpContextAccessor;
       // private readonly IUserService _userService;

        public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,
             IMapper mapper)
          //   IHttpContextAccessor httpContextAccessor,
           // IUserService userService)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
            //this._httpContextAccessor = httpContextAccessor;
           // this._userService = userService;
        }

        /* public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
         {
             var leaveAllocations = new List<LeaveAllocation>();
             var allocations = new List<LeaveAllocationDto>();

             if (request.IsLoggedInUser)
             {
                 var userId = _httpContextAccessor.HttpContext.User.FindFirst(
                     q => q.Type == CustomClaimTypes.Uid)?.Value;
                 leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails(userId);

                 var employee = await _userService.GetEmployee(userId);
                 allocations = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
                 foreach (var alloc in allocations)
                 {
                     alloc.Employee = employee;
                 }
             }
             else
             {
                 leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
                 allocations = _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
                 foreach (var req in allocations)
                 {
                     req.Employee = await _userService.GetEmployee(req.EmployeeId);
                 }
             }

             return allocations;
         }*/
        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocations = await _leaveAllocationRepository.GetLeaveAllocationsWithDetails();
            return _mapper.Map<List<LeaveAllocationDto>>(leaveAllocations);
           
        }
    }
}
