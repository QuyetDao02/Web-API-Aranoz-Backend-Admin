using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Interface
{
    public interface IDoNoiThatDAL
    {
        DoNoiThat GetProductId(int id);
        List<DoNoiThat> GetAllData();
        void Create(DoNoiThat sp);
        void DeleteProduct(int id);
        void EditProduct(DoNoiThat sp);
        List<DoNoiThat> Search(int page, int pagesize, string nd);
    }
}
