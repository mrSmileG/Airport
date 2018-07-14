using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace DAL.InMemory.Repositories
{
    internal class TicketRepository : BaseRepository<Ticket>
    {

        public TicketRepository(AppContext appContext) : base(appContext)
        {
        }

        public override Ticket Create(Ticket ticket)
        {
            _appContext.Tickets.Add(ticket);
            var tk = _appContext.Tickets.Find(t => t.Equals(ticket));
            return tk;
        }

        public override void Delete(Guid id)
        {
            var ticket = _appContext.Tickets.Find(t => t.Id == id);
            if (ticket != null)
                _appContext.Tickets.Remove(ticket);
        }

        public override Ticket Get(Guid id)
        {
            return _appContext.Tickets.Find(t => t.Id == id);
        }

        public override IEnumerable<Ticket> GetList()
        {
            return _appContext.Tickets;
        }

        public override void Update(Ticket ticket)
        {
            var entity = _appContext.Tickets.Find(t => t.Id == ticket.Id);

            if (entity != null)
            {
                entity.Price = ticket.Price;
            }
        }
    }
}
