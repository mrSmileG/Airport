using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class PilotRepository : BaseRepository<Pilot>
    {

        public PilotRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Pilot Create(Pilot pilot)
        {
            _appContext.Pilots.Add(pilot);
            var pl = _appContext.Pilots.Find(p => p.Equals(pilot));
            return pl;
        }

        public override void Delete(Guid id)
        {
            var pilot = _appContext.Pilots.Find(p => p.Id == id);
            if (pilot != null)
                _appContext.Pilots.Remove(pilot);
        }

        public override Pilot Get(Guid id)
        {
            return _appContext.Pilots.Find(p => p.Id == id);
        }

        public override IEnumerable<Pilot> GetList()
        {
            return _appContext.Pilots;
        }

        public override void Update(Pilot pilot)
        {
            var entity = _appContext.Pilots.Find(p => p.Id == pilot.Id);

            if (entity != null)
            {
                entity.Name = pilot.Name;
                entity.Birth = pilot.Birth;
                entity.Surname = pilot.Surname;
                entity.Experience = pilot.Experience;
            }
        }
    }
}
