using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        public IKhachHangBusiness db;
        public KhachHangController(IKhachHangBusiness _db)
        {
            db = _db;
        }
        [Route("Get-khachhang-Id/{id}")]
        [HttpGet]
        public KhachHang GetId(int id)
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
        [Route("Them-KhachHang")]
        [HttpPost]
        public IActionResult Create([FromBody] KhachHang sp)
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

        [Route("Sua-KhachHang")]
        [HttpPut]
        public IActionResult Edit([FromBody] KhachHang sp)
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

        [Route("Xoa-KhachHang")]
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
