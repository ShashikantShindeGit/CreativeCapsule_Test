using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CCBusinessLogic.Interfaces
{
    public interface IBaseInterface<T> where T : class
    {
        List<T> GetList(T objModel);
        T GetSingle(T objModel);
        int Insert(T objModel);
        int Update(T objModel);
        int Remove(T objModel);
    }
}
