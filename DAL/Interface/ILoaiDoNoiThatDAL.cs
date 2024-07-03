using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface ILoaiDoNoiThatDAL
    {
        LoaiDoNoiThat GetCategoryId(int id);
        List<LoaiDoNoiThat> getalldata();
        void Create(LoaiDoNoiThat sp);
        void DeleteProduct(int id);
        void EditProduct(LoaiDoNoiThat sp);
    }
}
