using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteLeaveTypeCommand :IRequest
    {
        public int Id { get; set; }
    }
}
