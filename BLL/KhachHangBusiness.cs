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
    public class KhachHangBusiness : IKhachHangBusiness
    {
        public IKhachHangDAL db;
        public KhachHangBusiness(IKhachHangDAL db)
        {
            this.db = db;
        }
        public KhachHang GetId(int id)
        {
            return db.GetId(id);
        }
        public List<KhachHang> getalldata()
        {
            return db.getalldata();
        }
        public void Create(KhachHang sp)
        {
            db.Create(sp);
        }
        public void Delete(int id)
        {
            db.Delete(id);
        }
        public void Edit(KhachHang sp)
        {
            db.Edit(sp);
        }
    }
}
