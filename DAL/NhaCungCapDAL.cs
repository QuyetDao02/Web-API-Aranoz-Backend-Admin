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
    public class NhaCungCapDAL : INhaCungCapDAL
    {
        public IDataHelper db;
        public NhaCungCapDAL(IDataHelper db)
        {
            this.db = db;
        }

        public NhaCungCap GetSupId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_supplie_byID", "@id", id);
                return sp.ConvertTo<NhaCungCap>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhaCungCap> GetAll()
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_all_supplie");
                return sp.ConvertTo<NhaCungCap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(NhaCungCap ncc)
        {
            DateTime dt = DateTime.Now;
            try
            {
                db.ExecuteProcedure("Create_supplier", "@Ten", ncc.TenNCC, "@DiaChi", ncc.DiaChi,
                                    "@sdt", ncc.Sdt);
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
                db.ExecuteProcedure("Delete_supplier", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(NhaCungCap ncc)
        {
            try
            {
                db.ExecuteProcedure("Update_supplier", "@Ma", ncc.MaNCC,
                                     "@Ten", ncc.TenNCC, "@DiaChi", ncc.DiaChi,
                                    "@sdt", ncc.Sdt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<NhaCungCap> Search(int page, int pagesize, string nd)
        {
            try
            {
                return db.ExcuteProcedureReturnDatatable("timkiem", "@Page", page,
                                                  "@Pagesize", pagesize,
                                                  "@Search", nd).ConvertTo<NhaCungCap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
