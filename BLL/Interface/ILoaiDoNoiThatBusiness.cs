using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ILoaiDoNoiThatBusiness
    {
        LoaiDoNoiThat GetCategoryId(int id);
        List<LoaiDoNoiThat> getalldata();
        void Create(LoaiDoNoiThat sp);
        void Update(LoaiDoNoiThat sp);
        void Delete(int id);
    }
}
