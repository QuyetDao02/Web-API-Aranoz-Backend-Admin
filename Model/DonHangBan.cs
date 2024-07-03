using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class DonHangBan
    {
        public int MaDHB { get; set; }
        public int MaKH { get; set; }
        public DateTime NgayLap { get; set; }
        public string DiaChi { get; set; }
        public int TinhTrang { get; set; }
        public string GhiChu { get; set; }
        public decimal TongTien { get; set; }
        public List<ChiTietDonHangBan> ChiTietDonHangBans { get; set; }
    }
    public class ChiTietDonHangBan
    {
        public int MaDNT { get; set; }
        public int SoLuong { get; set; }
        public decimal Gia { get; set; }
    }
}
