using BLL.Interface;
using DAL.Interface;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DonHangBanBusiness : IDonHangBanBusiness
    {
        public IDonHangBanDAL dbsp;
        public DonHangBanBusiness(IDonHangBanDAL _dbsp)
        {
            dbsp = _dbsp;
        }
        public List<DonHangBan> GetAllData()
        {
            return dbsp.GetAllData();
        }

        public void Delete(int id)
        {
            dbsp.Delete(id);
        }
        public void Edit(DonHangBan sp)
        {
            dbsp.Edit(sp);
        }


    }
}
