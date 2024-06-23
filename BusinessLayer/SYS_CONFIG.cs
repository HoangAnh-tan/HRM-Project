using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class SYS_CONFIG
    {
        QLTIENLUONGEntities db = new QLTIENLUONGEntities();
        public tb_CONFIG getItem(string name)
        {
            return db.tb_CONFIG.FirstOrDefault(x=>x.NAME == name);
        }
    }
}
