using DAL.Helper.Interface;
using DAL.Interface;
using DAL.Helper;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL : IKhachHangDAL
    {
        public IDataHelper db;
        public KhachHangDAL(IDataHelper db)
        {
            this.db = db;
        }
        public KhachHang GetId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_khachhang_id", "@id", id);
                return sp.ConvertTo<KhachHang>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<KhachHang> getalldata()
        {
            return db.ExcuteProcedureReturnDatatable("all_khachhang").ConvertTo<KhachHang>().ToList();
        }
        public void Create(KhachHang sp)
        {
            try
            {
                db.ExecuteProcedure("add_khachhang", "@ten", sp.TenKH, "@diachi", sp.Diachi, "@sdt", sp.Sdt,
                    "@email", sp.email, "@pass", sp.pass);
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
                db.ExecuteProcedure("delete_khachhang", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(KhachHang sp)
        {
            try
            {
                db.ExecuteProcedure("update_khachhang", "@ma", sp.MaKH,
                                     "@ten", sp.TenKH, "@diachi", sp.Diachi, "@sdt", sp.Sdt,
                    "@email", sp.email, "@pass", sp.pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
