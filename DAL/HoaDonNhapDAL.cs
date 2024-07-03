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
    public class HoaDonNhapDAL : IHoaDonNhapDAL
    {
        public IDataHelper db;
        public HoaDonNhapDAL(IDataHelper db)
        {
            this.db = db;
        }

        public HoaDonNhap GetBillId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_bill_id", "@id", id);
                return sp.ConvertTo<HoaDonNhap>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public HoaDonNhap GetDataId(int id)
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("get_all_detail_bill_id", "@id", id);
                return sp.ConvertTo<HoaDonNhap>().FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<HoaDonNhap> GetAll()
        {
            try
            {
                var sp = db.ExcuteProcedureReturnDatatable("getallbill");
                return sp.ConvertTo<HoaDonNhap>().ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Create(HoaDonNhap hdn)
        {
            DateTime dt = DateTime.Now;
            try
            {
                db.ExecuteProcedure("AddBill", "@MaNV", hdn.MaNV, "@MaNCC", hdn.Mancc
                                   );
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
                db.ExecuteProcedure("deletebill", "@id", id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Update(HoaDonNhap hdn)
        {
            try
            {
                db.ExecuteProcedure("updatebill", "@Ma", hdn.MaHDN,
                                    "@mancc", hdn.Mancc, "@MaNV", hdn.MaNV,
                                    "@NgayLap", hdn.Ngaylap, "@tinhtrang", hdn.TinhTrang) ;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
