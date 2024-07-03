using BLL.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DonHangBanController : ControllerBase
    {
        IDonHangBanBusiness db;
        public DonHangBanController(IDonHangBanBusiness db)
        {
            this.db = db;
        }
        [Route("get-all-order")]
        [HttpGet]
        public List<DonHangBan> getall()
        {
            return db.GetAllData();
        }



        [Route("Update-Input-order")]
        [HttpPut]
        public IActionResult Update([FromBody] DonHangBan hdn)
        {
            try
            {
                db.Edit(hdn);
                return Ok("Sửa thành công");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("delete-input-order")]
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                db.Delete(id);
                return Ok("Xóa thành công hóa đơn có mã id = " + id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
