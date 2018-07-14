using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class PlaneTypeRepository : BaseRepository<PlaneType>
    {

        public PlaneTypeRepository(AppContext appContext) : base(appContext)
        {
        }

        public override PlaneType Create(PlaneType planeType)
        {
            _appContext.PlaneTypes.Add(planeType);
            var type = _appContext.PlaneTypes.Find( t => t.Equals(planeType));
            return type;
        }

        public override void Delete(Guid id)
        {
            var type = _appContext.PlaneTypes.Find(t => t.Id == id);
            if (type != null)
                _appContext.PlaneTypes.Remove(type);
        }

        public override PlaneType Get(Guid id)
        {
            return _appContext.PlaneTypes.Find(t => t.Id == id);
        }

        public override IEnumerable<PlaneType> GetList()
        {
            return _appContext.PlaneTypes;
        }

        public override void Update(PlaneType planeType)
        {
            var entity = _appContext.PlaneTypes.Find(t => t.Id == planeType.Id);
            if (entity != null)
            {
                entity.Model = planeType.Model;
                entity.Carrying = planeType.Carrying;
                entity.Places = planeType.Places;
            }
        }
    }
}
