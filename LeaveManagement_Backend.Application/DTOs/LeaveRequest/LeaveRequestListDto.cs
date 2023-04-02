using LeaveManagement_Backend.Application.DTOs.Common;
using LeaveManagement_Backend.Application.DTOs.LeaveType;
using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}
