using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IKhachHangDAL
    {
        KhachHang GetId(int id);
        List<KhachHang> getalldata();
        void Create(KhachHang sp);
        void Delete(int id);
        void Edit(KhachHang sp);
    }
}
