using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event.Manager.Domain.Base
{
    public interface IRepository<T> where T : IAggregateRoot
    {
    }
}
