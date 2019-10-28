using System;
using System.Threading.Tasks;
using MicroserviceCore.TeamService.Models;

namespace MicroserviceCore.TeamService.LocationClient
{
    public interface ILocationClient
    {
        Task<LocationRecord> GetLatestForMember(Guid memberId);
        Task<LocationRecord> AddLocation(Guid memberId, LocationRecord locationRecord);
    }
}