using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL.Interface
{
   public interface IDoNoiThatBusiness
    {
        DoNoiThat GetProductId(int id);
        List<DoNoiThat> GetAllData();
        void Create(DoNoiThat sp);
        void Update(DoNoiThat sp);
        void Delete(int id);
        List<DoNoiThat> Search(int page, int pagesize, string nd);
    }
}
