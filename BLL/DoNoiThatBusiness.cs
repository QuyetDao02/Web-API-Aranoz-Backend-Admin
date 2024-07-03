using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface;
using DAL.Interface;
using Model;

namespace BLL
{
    public class DoNoiThatBusiness : IDoNoiThatBusiness
    {
        public IDoNoiThatDAL dbsp;
        public DoNoiThatBusiness(IDoNoiThatDAL _dbsp)
        {
            dbsp = _dbsp;
        }
        public DoNoiThat GetProductId(int id)
        {
            return dbsp.GetProductId(id);
        }
        public List<DoNoiThat> GetAllData()
        {
            return dbsp.GetAllData();
        }

        public void Create(DoNoiThat sp)
        {
            dbsp.Create(sp);
        }
        public void Delete(int id)
        {
            dbsp.DeleteProduct(id);
        }
        public void Update(DoNoiThat sp)
        {
            dbsp.EditProduct(sp);
        }
        public List<DoNoiThat> Search(int page, int pagesize, string nd)
        {
            return dbsp.Search(page, pagesize, nd);
        }
    }
}
