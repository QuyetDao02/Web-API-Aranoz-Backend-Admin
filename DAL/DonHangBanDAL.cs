//using DAL.Helper.Interface;
//using DAL.Interface;
//using DAL.Helper;
//using Model;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL
//{
//    public class DonHangBanDAL : IDonHangBanDAL
//    {
//        public IDataHelper db;
//        public DonHangBanDAL(IDataHelper dbhp)
//        {
//            db = dbhp;
//        }


//        public List<DonHangBan> GetAllData()
//        {
//            try
//            {
//                var sp = db.ExcuteProcedureReturnDatatable("get_order");
//                return sp.ConvertTo<DonHangBan>().ToList();
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }

//        public void Delete(int id)
//        {
//            try
//            {
//                db.ExecuteProcedure("Delete_order", "@ma", id);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//        public void Edit(DonHangBan sp)
//        {
//            try
//            {
//                db.ExecuteProcedure("Update_order", "@Ma", sp.MaDHB,
//                                     "@tinhtrang", sp.TinhTrang);
//            }
//            catch (Exception ex)
//            {
//                throw ex;
//            }
//        }
//        //public List<DonHangBan> Search(int page, int pagesize, string nd)
//        //{
//        //    try
//        //    {
//        //        return db.ExcuteProcedureReturnDatatable("timkiem", "@Page", page,
//        //                                          "@Pagesize", pagesize,
//        //                                          "@Search", nd).ConvertTo<DonHangBan>().ToList();
//        //    }
//        //    catch (Exception ex)
//        //    {
//        //        throw ex;
//        //    }
//        //}
//    }
//}
