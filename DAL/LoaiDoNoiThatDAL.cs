using DAL.Helper.Interface;
using DAL.Interface;
using Model;
using DAL.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDoNoiThatDAL : ILoaiDoNoiThatDAL
    {
        public IDataHelper db;
        public LoaiDoNoiThatDAL(IDataHelper db)
        {
            this.db = db;
        }
        public LoaiDoNoiThat GetCategoryId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_id_category", "@id", id);
                return sp.ConvertTo<LoaiDoNoiThat>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<LoaiDoNoiThat> getalldata()
        {
            return db.ExcuteProcedureReturnDatatable("get_all_category").ConvertTo<LoaiDoNoiThat>().ToList();
        }
        public void Create(LoaiDoNoiThat sp)
        {
            try
            {
                db.ExecuteProcedure("Create_Category", "@Ten", sp.TenLDNT, "@Mota", sp.MoTa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void DeleteProduct(int id)
        {
            try
            {
                db.ExecuteProcedure("Delete_Category", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditProduct(LoaiDoNoiThat sp)
        {
            try
            {
                db.ExecuteProcedure("Update_Category", "@Ma", sp.MaLDNT,
                                     "@Ten", sp.TenLDNT,
                                     "@Mota", sp.MoTa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
