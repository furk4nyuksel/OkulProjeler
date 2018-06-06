using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev.BLL
{
  public  interface IReposityory<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(int itemid);
        List<T> SelectAll();
        T SelectByID(int itemid);
        List<T> SearchCargo(string Kargoname);
    }
}
