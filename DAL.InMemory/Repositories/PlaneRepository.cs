using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class PlaneRepository : BaseRepository<Plane>
    {

        public PlaneRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Plane Create(Plane plane)
        {
            _appContext.Planes.Add(plane);
            var pl = _appContext.Planes.Find(p => p.Equals(plane));
            return pl;
        }

        public override void Delete(Guid id)
        {
            var plane = _appContext.Planes.Find(p => p.Id == id);
            if (plane != null)
                _appContext.Planes.Remove(plane);
        }

        public override Plane Get(Guid id)
        {
            return _appContext.Planes.Find(p => p.Id == id);
        }

        public override IEnumerable<Plane> GetList()
        {
            return _appContext.Planes;
        }

        public override void Update(Plane plane)
        {
            var entity = _appContext.Planes.Find(p => p.Id == plane.Id);

            if (entity != null)
            {
                entity.Name = plane.Name;
                entity.Lifetime = plane.Lifetime;
                entity.ReleaseDate = plane.ReleaseDate;
                entity.Type = plane.Type;
            }
        }
    }
}
