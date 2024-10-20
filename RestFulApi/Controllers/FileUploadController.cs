using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace imageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileUploadController : ControllerBase
    {
        private static IWebHostEnvironment _webHostEnvironment;

        public FileUploadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        [Route("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                try
                {
                    string imagesDirectory = Path.Combine(Directory.GetCurrentDirectory(),"..","..", "httpdocs", "assets", "cozastore-master", "images", "products");
                    if (!Directory.Exists(imagesDirectory))
                    {
                        Directory.CreateDirectory(imagesDirectory);
                    }
                    string fileExtension = Path.GetExtension(file.FileName);
                    string fileName = Guid.NewGuid().ToString() + fileExtension;
                    string fullPath = Path.Combine(imagesDirectory, fileName);

             
                    using (FileStream filestream = new FileStream(fullPath, FileMode.Create))
                    {
                        await file.CopyToAsync(filestream);
                    }

                    // Başarılı bir yanıt döndür
                    return Ok(new { filePath = fileName });
                }
                catch (Exception ex)
                {
                    return StatusCode(500, new { message = ex.Message });
                }
            }
            else
            {
                return BadRequest(new { message = "Yüklenemedi" });
            }
        }
    }
}
