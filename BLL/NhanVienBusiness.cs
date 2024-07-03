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
    public class NhanVienBusiness : INhanVienBusiness
    {
        public INhanVienDAL db;
        public NhanVienBusiness(INhanVienDAL db)
        {
            this.db = db;
        }
        public NhanVien GetId(int id)
        {
            return db.GetId(id);
        }
        public List<NhanVien> getalldata()
        {
            return db.getalldata();
        }
        public void Create(NhanVien sp)
        {
            db.Create(sp);
        }
        public void Delete(int id)
        {
            db.Delete(id);
        }
        public void Edit(NhanVien sp)
        {
            db.Edit(sp);
        }
    }
}
