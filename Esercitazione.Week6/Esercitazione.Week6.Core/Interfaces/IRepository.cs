using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione.Week6.Core.Interfaces
{
    public interface IRepository<TEntity>
    {
        TEntity GetById(int id);
        bool Add(TEntity item);
        bool Update(TEntity item);
        bool Delete(TEntity item);
    }
}
