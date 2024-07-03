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
    public class DonHangBusiness : IDonHangBusiness
    {
        public IDonHangDAL db;
        public DonHangBusiness(IDonHangDAL db)
        {
            this.db = db;
        }

        public void AddCart(DonHangBan dh)
        {
            db.AddCart(dh);
        }
    }
}
