﻿using System.Collections.Generic;
using Shrooms.DataTransferObjects.Models;
using Shrooms.DataTransferObjects.Models.Monitors;

namespace Shrooms.Domain.Services.Monitors
{
    public interface IMonitorService
    {
        IEnumerable<MonitorDTO> GetMonitorList(int organizationId);
        MonitorDTO GetMonitorDetails(int organizationId, int monitorId);
        void CreateMonitor(MonitorDTO newMonitor, UserAndOrganizationDTO userAndOrganizationDTO);
        void UpdateMonitor(MonitorDTO monitorDTO, UserAndOrganizationDTO userAndOrganizationDTO);
    }
}
