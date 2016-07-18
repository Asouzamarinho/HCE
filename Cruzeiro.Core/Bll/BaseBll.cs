using System;
using System.Data.Entity;
using System.Linq;
using Cruzeiro.Core.Model;
using Cruzeiro.Core.Model.Beans;
using Cruzeiro.Core.Model.Context;

namespace Cruzeiro.Core.Bll
{
    public class BaseBll<T> where T : SyncBean, new()
    {
        public CruzeiroContext Context
        {
            get { return _context ?? (_context = new CruzeiroContext()); }
            set { _context = value; }
        }

        protected DbSet<T> Set
        {
            get { return _set ?? (_set = Context.Set<T>()); }
        }

        protected DateTime GetLastChange()
        {
            return Set.DefaultIfEmpty(new T {LastChange = DateTime.MinValue}).Max(_ => _.LastChange);
        }

        public T[] GetAll()
        {
            return Set.AsEnumerable().ToArray();
        }

        public T FindById(int id)
        {
            return Set.Find(id);
        }

        private CruzeiroContext _context;
        private DbSet<T> _set;
    }
}