using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Helper.Interface;
using DAL.Interface;
using DAL.Helper;
using Model;

namespace DAL
{
    public class DonHangDAL : IDonHangDAL
    {
        public IDataHelper db;
        public DonHangDAL(IDataHelper db)
        {
            this.db = db;
        }
        public void AddCart(DonHangBan dh)
        {
            DateTime dt = DateTime.Now;
            decimal sum = 0;
            List<ChiTietDonHangBan> list = dh.ChiTietDonHangBans;
            for (int i = 0; i < list.Count(); i++)
            {
                DoNoiThat sp = db.ExcuteProcedureReturnDatatable("GetProductById", "@Id", list[i].MaDNT).ConvertTo<DoNoiThat>().FirstOrDefault();
                sum += sp.Giaban * list[i].SoLuong;
            }

            db.ExecuteProcedure("AddToCart", "@MaKH", dh.MaKH,
                                "@NgayLap", dh.NgayLap = dt,
                                "@DiaChi", dh.DiaChi,
                                "@GhiChu", dh.GhiChu,
                                "@TongTien", sum
                                );
            for (int i = 0; i < list.Count(); i++)
            {
                decimal tam = 0;
                DoNoiThat sp = db.ExcuteProcedureReturnDatatable("GetProductById", "@Id", list[i].MaDNT).ConvertTo<DoNoiThat>().FirstOrDefault();
                tam += sp.Giaban * list[i].SoLuong;
                db.ExecuteProcedure("Order_details", "@Masp", list[i].MaDNT,
                                    "@sl", list[i].SoLuong, "@gia", tam);
            }
        }
    }
}
