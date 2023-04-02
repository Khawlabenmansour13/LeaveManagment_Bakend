using LeaveManagement_Backend.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveRequests.Requests.Commands
{
    public class UpdateLeaveRequestCommand : IRequest<Unit>

    {
        internal readonly object LeaveRequestDto;

        public ChangeLeaveRequestApprovalDto ChangeLeaveRequestApproval { get; set; }
        public LeaveRequestDto LeaveRequest { get; internal set; }
        public object ChangeLeaveRequestApprovalDto { get; internal set; }
    }
}
