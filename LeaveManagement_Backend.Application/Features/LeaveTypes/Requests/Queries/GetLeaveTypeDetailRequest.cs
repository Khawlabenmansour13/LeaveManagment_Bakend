﻿using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveTypes.Requests.Queries
{
    public class GetLeaveTypeDetailRequest : IRequest<CreateLeaveTypeDto>
    {
        public int Id { get; set; }
    }
}