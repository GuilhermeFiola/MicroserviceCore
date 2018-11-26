using System;
using System.Collections.Generic;
using System.Linq;
using MicroserviceCore.TeamService.Models;

namespace MicroserviceCore.TeamService.Persistence
{
    public class MemoryTeamRepository : ITeamRepository
    {
        protected static ICollection<Team> _teams;

        public MemoryTeamRepository()
        {
            if (_teams == null)
            {
                _teams = new List<Team>();
            }
        }

        public MemoryTeamRepository(ICollection<Team> teams)
        {
            _teams = teams;
        }

        public IEnumerable<Team> List()
        {
            return _teams;
        }

        public Team Get(Guid id)
        {
            return _teams.FirstOrDefault(t => t.ID == id);
        }

        public Team Add(Team team)
        {
            _teams.Add(team);
            return team;
        }

        public Team Update(Team t)
        {
            Team team = this.Delete(t.ID);

            if (team != null)
            {
                team = this.Add(t);
            }

            return team;
        }

        public Team Delete(Guid id)
        {
            var teamsQuery = _teams.Where(t => t.ID == id);
            Team team = null;

            if (teamsQuery.Count() > 0)
            {
                team = teamsQuery.First();
                _teams.Remove(team);
            }

            return team;
        }
    }
}