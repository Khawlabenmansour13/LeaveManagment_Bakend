using LeaveManagement_Backend.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces
{
    public interface ILeaveRequestRepository : IGenericRepository<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestWithDetails(int id);
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails();
        Task<List<LeaveRequest>> GetLeaveRequestsWithDetails(string userId);
        Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? ApprovalStatus);
        Task Update(Task<LeaveRequest> leaveRequest);
        Task Get(object id);
    }

}

