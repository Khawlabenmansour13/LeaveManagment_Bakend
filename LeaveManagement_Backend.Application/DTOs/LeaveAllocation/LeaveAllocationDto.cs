using LeaveManagement_Backend.Application.DTOs.Common;
using LeaveManagement_Backend.Domaine.Entities;
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
            public LeaveType LeaveType { get; set; }
            public int LeaveTypeId { get; set; }
            public int Period { get; set; }
            ///spublic string EmployeeId { get; set; }
        }
    
}
