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
    public class LoaiDoNoiThatBusiness : ILoaiDoNoiThatBusiness
    {
        public ILoaiDoNoiThatDAL db;
        public LoaiDoNoiThatBusiness(ILoaiDoNoiThatDAL db)
        {
            this.db = db;
        }
        public LoaiDoNoiThat GetCategoryId (int id)
        {
            return db.GetCategoryId(id);
        }
        public List<LoaiDoNoiThat> getalldata()
        {
            return db.getalldata();
        }
        public void Create(LoaiDoNoiThat sp)
        {
            db.Create(sp);
        }
        public void Delete(int id)
        {
            db.DeleteProduct(id);
        }
        public void Update(LoaiDoNoiThat sp)
        {
            db.EditProduct(sp);
        }
    }
}
