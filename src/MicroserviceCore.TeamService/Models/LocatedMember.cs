using System;

namespace MicroserviceCore.TeamService.Models
{
    public class LocatedMember : Member
    {
        public LocationRecord LastLocation { get; set; }
    }
}