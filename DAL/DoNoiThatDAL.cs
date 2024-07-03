using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Helper.Interface;
using DAL.Interface;
using DAL.Helper;


namespace DAL
{
    public class DoNoiThatDAL : IDoNoiThatDAL
    {
        public IDataHelper db;
        public DoNoiThatDAL(IDataHelper dbhp)
        {
            db = dbhp;
        }

        public DoNoiThat GetProductId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("GetProductById", "@Id", id);
                return sp.ConvertTo<DoNoiThat>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DoNoiThat> GetAllData()
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("GetAllProduct");
                return sp.ConvertTo<DoNoiThat>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(DoNoiThat sp)
        {
            try
            {
                db.ExecuteProcedure("Create_Product", "@Ten", sp.TenDNT, "@Loai", sp.MaLDNT, "@Mota", sp.MoTa, "@Anh", sp.HinhAnh);
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
                db.ExecuteProcedure("Delete_Product", "@ma", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void EditProduct(DoNoiThat sp)
        {
            try
            {
                db.ExecuteProcedure("Update_Product", "@Ma", sp.MaDNT,
                                     "@Ten", sp.TenDNT,
                                     "@Maloai", sp.MaLDNT,
                                     "@Mota", sp.MoTa,
                                     "@Anh", sp.HinhAnh);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<DoNoiThat> Search(int page, int pagesize, string nd)
        {
            try
            {
                return db.ExcuteProcedureReturnDatatable("timkiem", "@Page", page,
                                                  "@Pagesize", pagesize,
                                                  "@Search", nd).ConvertTo<DoNoiThat>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
