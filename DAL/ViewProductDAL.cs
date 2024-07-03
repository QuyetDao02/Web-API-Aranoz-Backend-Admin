using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Helper.Interface;
using DAL.Interface;
using Model;
using DAL.Helper;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;

namespace DAL
{
    public class ViewProductDAL : IViewProductDAL
    {
        public IDataHelper db;
        public ViewProductDAL(IDataHelper db)
        {
            this.db = db;
        }
        public List<DoNoiThat> GetAllData()
        {
            return db.ExcuteProcedureReturnDatatable("GetAllProduct").ConvertTo<DoNoiThat>().ToList();
        }
        public List<DoNoiThat> DoNoiThatMoi(int sl)
        {
            return db.ExcuteProcedureReturnDatatable("New_Product", "@sl", sl).ConvertTo<DoNoiThat>().ToList();
        }
        public List<DoNoiThat> DoNoiThatBanChay(int sl)
        {
            return db.ExcuteProcedureReturnDatatable("Best_Selling_Product", "@sl", sl).ConvertTo<DoNoiThat>().ToList();
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
        public List<DoNoiThat> Get_product_categoryid(int maloai)
        {
            return db.ExcuteProcedureReturnDatatable("get_product_categoryid", "@maLDNT", maloai).ConvertTo<DoNoiThat>().ToList();
        }
    }
}
