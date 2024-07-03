using BLL.Interface;
using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TinTucBusiness : ITinTucBusiness
    {
        public ITinTucDAL db;
        public TinTucBusiness(ITinTucDAL db)
        {
            this.db = db;
        }
        public TinTuc GetId(int id)
        {
            return db.GetId(id);
        }
        public List<TinTuc> getalldata()
        {
            return db.getalldata();
        }
        public void Create(TinTuc sp)
        {
            db.Create(sp);
        }
        public void Delete(int id)
        {
            db.Delete(id);
        }
        public void Edit(TinTuc sp)
        {
            db.Edit(sp);
        }
    }
}
