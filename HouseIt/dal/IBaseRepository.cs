using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.dal
{
    interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetEntities(T entity);
        T FindEntityById(object id);
        void CreateEntity(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
    }
}
