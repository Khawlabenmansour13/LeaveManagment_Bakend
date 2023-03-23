﻿using LeaveManagement_Backend.Domaine.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManagement_Backend.Application.Contracts.Persistence.Interfaces
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int id);
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails(string userId);
        Task<bool> AllocationExists(string userId, int leaveTypeId, int period);
        Task AddAllocations(List<LeaveAllocation> allocations);
        Task<LeaveAllocation> GetUserAllocations(string userId, int leaveTypeId);
   
    }
}
