using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IHoaDonNhapDAL
    {
        List<HoaDonNhap> GetAll();
        HoaDonNhap GetDataId(int id);
        HoaDonNhap GetBillId(int id);
        void Create(HoaDonNhap hdn);
        void Delete(int id);
        void Update(HoaDonNhap hdn);
    }
}
