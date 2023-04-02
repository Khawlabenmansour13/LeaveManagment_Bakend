using LeaveManagement_Backend.Application.DTOs.Common;
using LeaveManagement_Backend.Application.DTOs.TypeRequest;
using LeaveManagement_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.DTOs.LeaveAllocation
{
    
        public class LeaveAllocationDto : BaseDto
        {
            public int NumberOfDays { get; set; }
            public LeaveTypeDto LeaveType { get; set; }
            public int LeaveTypeId { get; set; }
            public int Period { get; set; }
            ///public string EmployeeId { get; set; }
        }
    
}
