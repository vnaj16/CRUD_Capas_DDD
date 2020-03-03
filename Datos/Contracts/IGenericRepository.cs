using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Datos.Contracts
{
    public interface IGenericRepository<Entity> where Entity:class
    {
        int Add(Entity entity);
        int Edit(Entity entity);
        int Remove(int ID);
        IEnumerable<Entity> GetAll();
    }
}
