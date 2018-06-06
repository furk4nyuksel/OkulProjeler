using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ev.DAL;
namespace Ev.BLL
{
  public  class ShippersRepository: IReposityory<Shippers>
    {
        NorthwindEntities db = DBTools.DBInstance;

        public void Delete(int itemid)
        {
            db.Shippers.Remove(db.Shippers.Find(itemid));
            db.SaveChanges();
           

        }

        public void Insert(Shippers item)
        {
            db.Shippers.Add(item);
            db.SaveChanges();
        }

        public List<Shippers> SearchCargo(string Kargoname)
        {
            return  db.Shippers.Where(s => s.CompanyName.Contains(Kargoname)).ToList();

            
        }

        public List<Shippers> SelectAll()
        {
            return db.Shippers.ToList();
        }

        public Shippers SelectByID(int itemid)
        {
            return db.Shippers.Find(itemid);
        }

        public void Update(Shippers item)
        {
            Shippers gelen = db.Shippers.Find(item.ShipperID);
            db.Entry(gelen).CurrentValues.SetValues(item);
            db.SaveChanges();
        }
    }
}
