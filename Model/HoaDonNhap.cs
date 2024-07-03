using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class HoaDonNhap
    {
        public int MaHDN { get; set; }
        public int MaNV { get; set; }
        public int Mancc { get; set; }
        public DateTime Ngaylap { get; set; }
        public bool TinhTrang { get; set; }
        public List<ChiTietHoaDonNhap> listcthdn { get; set; }
        public decimal TongTien { get; set; }
    }
    public class ChiTietHoaDonNhap
    {
        public int MaHDN { get; set; }
        public int MaDNT { get; set; }
        public int SoLuong { get; set; }
        public float Gia { get; set; }
    }
}
