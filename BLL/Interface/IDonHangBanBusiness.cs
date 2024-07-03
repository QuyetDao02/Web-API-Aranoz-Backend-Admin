using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IDonHangBanBusiness
    {
        List<DonHangBan> GetAllData();
        void Delete(int id);
        void Edit(DonHangBan sp);
      
    }
}
