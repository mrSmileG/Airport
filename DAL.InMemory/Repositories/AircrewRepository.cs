using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class AircrewRepository : BaseRepository<Aircrew>
    {

        public AircrewRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Aircrew Create(Aircrew aircrew)
        {
            _appContext.Aircrews.Add(aircrew);
            var ac = _appContext.Aircrews.Find(a => a.Equals(aircrew));
            return ac;
        }

        public override void Delete(Guid id)
        {
            var aircrew = _appContext.Aircrews.Find(a => a.Id == id);
            if (aircrew != null)
                _appContext.Aircrews.Remove(aircrew);
        }

        public override Aircrew Get(Guid id)
        {
            return _appContext.Aircrews.Find(a => a.Id == id);
        }

        public override IEnumerable<Aircrew> GetList()
        {
            return _appContext.Aircrews;
        }

        public override void Update(Aircrew aircrew)
        {
            var entity = _appContext.Aircrews.Find(a => a.Id == aircrew.Id);

            if (entity != null)
            {
                entity.Stewards = aircrew.Stewards;
                entity.Pilot = aircrew.Pilot;
            }
        }
    }
}
