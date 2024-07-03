using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiDoNoiThatController : ControllerBase
    {
        public ILoaiDoNoiThatBusiness db;
        public LoaiDoNoiThatController(ILoaiDoNoiThatBusiness _db)
        {
            db = _db;
        }
        [Route("Get-category-Id/{id}")]
        [HttpGet]
        public LoaiDoNoiThat GetCategoryId(int id)
        {
            return db.GetCategoryId(id);
        }
        [Route("get-all-category")]
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                var data = db.getalldata();
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("Them-LoaiDoNoiThat")]
        [HttpPost]
        public IActionResult Create([FromBody] LoaiDoNoiThat sp)
        {
            try
            {
                db.Create(sp);
                return Ok("Thêm thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [Route("Sua-LoaiDoNoiThat")]
        [HttpPut]
        public IActionResult EditProduct([FromBody] LoaiDoNoiThat sp)
        {
            try
            {
                db.Update(sp);
                return Ok("Sửa thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Xoa-LoaiDoNoiThat")]
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                db.Delete(id);
                return Ok("Xóa thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
