using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BLL.Interface;
using DAL.Interface;


namespace BLL
{
    public class ViewProductBusiness : IViewProductBusiness
    {
        public IViewProductDAL db;
        public ViewProductBusiness(IViewProductDAL db)
        {
            this.db = db;
        }
        public List<DoNoiThat> GetAllData()
        {
            return db.GetAllData();
        }
        public List<DoNoiThat> DoNoiThatMoi(int sl)
        {
            return db.DoNoiThatMoi(sl);
        }
        public List<DoNoiThat> DoNoiThatBanChay(int sl)
        {
            return db.DoNoiThatBanChay(sl);
        }
        public DoNoiThat GetProductId(int id)
        {
            return db.GetProductId(id);
        }
        public List<DoNoiThat> Get_product_categoryid(int id)
        {
            return db.Get_product_categoryid(id);
        }
    }
}
