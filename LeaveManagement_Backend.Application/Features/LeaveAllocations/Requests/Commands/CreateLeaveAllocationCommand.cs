using LeaveManagement_Backend.Application.DTOs.LeaveAllocation;

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand  : IRequest<int>
    {
        public CreateLeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
