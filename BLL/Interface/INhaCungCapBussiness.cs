using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface INhaCungCapBussiness
    {
        List<NhaCungCap> GetAll();
        NhaCungCap GetSupId(int id);
        void Create(NhaCungCap ncc);
        void Delete(int id);
        void Update(NhaCungCap ncc);
        List<NhaCungCap> Search(int page, int pagesize, string nd);
    }
}
