using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL.Interface
{
    public interface IViewProductDAL
    {
        List<DoNoiThat> GetAllData();
        List<DoNoiThat> DoNoiThatMoi(int sl);
        List<DoNoiThat> DoNoiThatBanChay(int sl);
        DoNoiThat GetProductId(int id);
        List<DoNoiThat> Get_product_categoryid(int id);
    }
}
