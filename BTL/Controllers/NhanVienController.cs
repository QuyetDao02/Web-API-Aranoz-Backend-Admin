using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NhanVienController : ControllerBase
    {
        public INhanVienBusiness db;
        public NhanVienController(INhanVienBusiness _db)
        {
            db = _db;
        }
        [Route("Get-NhanVien-Id/{id}")]
        [HttpGet]
        public NhanVien GetId(int id)
        {
            return db.GetId(id);
        }
        [Route("get-all")]
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
        [Route("Them-NhanVien")]
        [HttpPost]
        public IActionResult Create([FromBody] NhanVien sp)
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

        [Route("Sua-NhanVien")]
        [HttpPut]
        public IActionResult Edit([FromBody] NhanVien sp)
        {
            try
            {
                db.Edit(sp);
                return Ok("Sửa thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("Xoa-NhanVien")]
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
