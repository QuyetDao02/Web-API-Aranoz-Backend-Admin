using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface INhanVienDAL
    {
        NhanVien GetId(int id);
        List<NhanVien> getalldata();
        void Create(NhanVien sp);
        void Delete(int id);
        void Edit(NhanVien sp);
    }
}
