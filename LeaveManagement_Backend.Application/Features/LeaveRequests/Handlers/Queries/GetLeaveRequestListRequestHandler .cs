﻿using AutoMapper;
using LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces;
using LeaveManagement_Backend.Application.DTOs.LeaveRequest;
using LeaveManagement_Backend.Application.Features.LeaveRequests.Requests.Queries;
using LeaveManagement_Backend.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestListRequestHandler : IRequestHandler<GetLeaveRequestListRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;
       // private readonly IHttpContextAccessor _httpContextAccessor;
       //private readonly IUserService _userService;

        public GetLeaveRequestListRequestHandler(ILeaveRequestRepository leaveRequestRepository,
            IMapper mapper)
          //  IHttpContextAccessor httpContextAccessor,
           //IUserService userService)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
          //  this._httpContextAccessor = httpContextAccessor;
           // this._userService = userService;
        }

        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = new List<LeaveRequest>();
            var requests = new List<LeaveRequestListDto>();

          
            /*if (request.IsLoggedInUser)
            {
                var userId = _httpContextAccessor.HttpContext.User.FindFirst(
                    q => q.Type == CustomClaimTypes.Uid)?.Value;
                leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetails(userId);

                var employee = await _userService.GetEmployee(userId);
                requests = _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
                foreach (var req in requests)
                {
                    req.Employee = employee;
                }
            }
            else
            {*/
                 leaveRequests = await _leaveRequestRepository.GetLeaveRequestsWithDetails();
                 return requests = _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
             /*  foreach (var req in requests)
                {
                    req.Employee = await _userService.GetEmployee(req.RequestingEmployeeId);
                }
            }

            return requests;*/


        }
    }
}
