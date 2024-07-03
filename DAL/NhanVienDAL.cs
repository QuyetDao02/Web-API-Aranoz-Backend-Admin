using DAL.Helper.Interface;
using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interface;

namespace DAL
{
    public class NhanVienDAL : INhanVienDAL
    {
        public IDataHelper db;
        public NhanVienDAL(IDataHelper db)
        {
            this.db = db;
        }
        public NhanVien GetId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_NhanVien_id", "@id", id);
                return sp.ConvertTo<NhanVien>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhanVien> getalldata()
        {
            return db.ExcuteProcedureReturnDatatable("all_NhanVien").ConvertTo<NhanVien>().ToList();
        }
        public void Create(NhanVien sp)
        {
            try
            {
                db.ExecuteProcedure("add_NhanVien", "@ten", sp.TenNV, "@diachi", sp.Diachi, "@sdt", sp.Sdt,
                    "@email", sp.Email, "@pass", sp.pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Delete(int id)
        {
            try
            {
                db.ExecuteProcedure("delete_NhanVien", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(NhanVien sp)
        {
            try
            {
                db.ExecuteProcedure("update_NhanVien", "@ma", sp.MaNV,
                                     "@ten", sp.TenNV, "@diachi", sp.Diachi, "@sdt", sp.Sdt,
                    "@email", sp.Email, "@pass", sp.pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
