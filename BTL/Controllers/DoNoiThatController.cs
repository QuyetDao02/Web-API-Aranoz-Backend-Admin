using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Reflection.PortableExecutable;
using BLL.Interface;

namespace BTL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoNoiThatController : ControllerBase
    {
        public static IWebHostEnvironment env;

        public IDoNoiThatBusiness db;
        public DoNoiThatController(IDoNoiThatBusiness _db, IWebHostEnvironment envi)
        {
            db = _db;
            env = envi;
        }
        [Route("Get-Product-Id/{id}")]
        [HttpGet]
        public DoNoiThat GetProductId(int id)
        {
            return db.GetProductId(id);
        }

        [Route("Get-all--product")]
        [HttpGet]
        public List<DoNoiThat> GetAllProduct()
        {
            return db.GetAllData();
        }

        [Route("Them-DoNoiThat")]
        [HttpPost]
        public IActionResult Create([FromBody] DoNoiThat sp)
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

        [Route("Sua-DoNoiThat")]
        [HttpPut]
        public IActionResult EditProduct([FromBody] DoNoiThat sp)
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

        [Route("Xoa-DoNoiThat")]
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

        [Route("Tim-Kiem")]
        [HttpPost]
        public IActionResult Search([FromBody] Dictionary<string, object> formdata)
        {
            SearchData s = new SearchData();
            try
            {
                var page = int.Parse(formdata["page"].ToString());
                var pagesize = int.Parse(formdata["pagesize"].ToString());
                string search = "";
                if (formdata.Keys.Contains("search") && !string.IsNullOrEmpty(formdata["search"].ToString()))
                {
                    search = Convert.ToString(formdata["search"]);
                }
                var data = db.Search(page, pagesize, search);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("UploadImage/")]
        [HttpPost, DisableRequestSizeLimit]
        public string UploadImage(IFormFile image)
        {

            if (image.Length > 0)
            {
                if (!Directory.Exists(env.WebRootPath + "\\Upload\\Products\\"))
                {
                    Directory.CreateDirectory(env.WebRootPath + "\\Upload\\Products\\");
                }
                using (FileStream fileStream = System.IO.File.Create(env.WebRootPath + "\\Upload\\Products\\" + image.FileName))
                {
                    image.CopyTo(fileStream);
                    fileStream.Flush();
                    var urlAnh = "\\Upload\\Products\\" + image.FileName;


                    return urlAnh;
                }
            }

            return "error";
        }


    }
}
