using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TinTucController : ControllerBase
    {
        public ITinTucBusiness db;
        public TinTucController(ITinTucBusiness _db)
        {
            db = _db;
        }
        [Route("Get-TinTuc-Id/{id}")]
        [HttpGet]
        public TinTuc GetId(int id)
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
        [Route("Them-TinTuc")]
        [HttpPost]
        public IActionResult Create([FromBody] TinTuc sp)
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

        [Route("Sua-TinTuc")]
        [HttpPut]
        public IActionResult Edit([FromBody] TinTuc sp)
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

        [Route("Xoa-TinTuc")]
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
