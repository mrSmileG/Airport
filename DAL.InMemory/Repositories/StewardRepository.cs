using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class StewardRepository : BaseRepository<Steward>
    {

        public StewardRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Steward Create(Steward steward)
        {
            _appContext.Stewards.Add(steward);
            var st = _appContext.Stewards.Find(p => p.Equals(steward));
            return st;
        }

        public override void Delete(Guid id)
        {
            var steward = _appContext.Stewards.Find(s => s.Id == id);
            if (steward != null)
                _appContext.Stewards.Remove(steward);
        }

        public override Steward Get(Guid id)
        {
            return _appContext.Stewards.Find(s => s.Id == id);
        }

        public override IEnumerable<Steward> GetList()
        {
            return _appContext.Stewards;
        }

        public override void Update(Steward steward)
        {
            var entity = _appContext.Stewards.Find(s => s.Id == steward.Id);

            if (entity != null)
            {
                entity.Name = steward.Name;
                entity.Birth = steward.Birth;
                entity.Surname = steward.Surname;
            }
        }
    }
}
