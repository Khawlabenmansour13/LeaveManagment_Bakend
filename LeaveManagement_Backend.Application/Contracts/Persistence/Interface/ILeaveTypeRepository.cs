using LeaveManagement_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces
{
    public interface ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        Task Update(Task<LeaveType> leaveType);
    }
}
