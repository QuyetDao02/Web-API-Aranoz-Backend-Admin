using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IDonHangBanDAL
    {
        List<DonHangBan> GetAllData();
        void Delete(int id);
        void Edit(DonHangBan sp);
        List<DonHangBan> Search(int page, int pagesize, string nd);
    }
}
