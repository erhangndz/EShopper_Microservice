using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.Order.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {

        List<T> TGetList();
        T TGetById(int id);
        void TDelete(int id);
        void TUpdate(T entity);
        void TCreate(T entity);
    }
}
