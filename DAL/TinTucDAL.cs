using DAL.Helper.Interface;
using DAL.Helper;
using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TinTucDAL : ITinTucDAL
    {
        public IDataHelper db;
        public TinTucDAL(IDataHelper db)
        {
            this.db = db;
        }
        public TinTuc GetId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_tintuc_id", "@id", id);
                return sp.ConvertTo<TinTuc>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<TinTuc> getalldata()
        {
            return db.ExcuteProcedureReturnDatatable("all_tintuc").ConvertTo<TinTuc>().ToList();
        }
        public void Create(TinTuc sp)
        {
            try
            {
                db.ExecuteProcedure("add_tintuc", "@tieude", sp.TieuDe, "@anh", sp.anh, "@noidung", sp.NoiDung,
                    "@ngaydang", sp.NgayDang, "@manv", sp.MaNV);
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
                db.ExecuteProcedure("delete_tintuc", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Edit(TinTuc sp)
        {
            try
            {
                db.ExecuteProcedure("update_tintuc", "@ma", sp.MaTT,
                                     "@tieude", sp.TieuDe, "@anh", sp.anh, "@noidung", sp.NoiDung,
                    "@ngaydang", sp.NgayDang, "@manv", sp.MaNV);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
