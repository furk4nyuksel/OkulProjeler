using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ev.DAL;
namespace Ev.BLL
{
 public   class DBTools
    {
        
    
        private static NorthwindEntities _DbInstance;

        public static NorthwindEntities DBInstance
        {
            get
            {
                if (_DbInstance == null)
                {
                    _DbInstance = new NorthwindEntities();
                }
                return _DbInstance;
            }
        }
        
        
    }
}
