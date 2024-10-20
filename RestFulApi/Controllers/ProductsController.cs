using Microsoft.AspNetCore.Mvc;
using RestFulApi.Models;
using RestFulApi.Service;

namespace RestFulApi.Controllers
{
    [Route("api/products")]       
    [ApiController]
    public class ProductsController:ControllerBase
    {
        private readonly IProductsService _productsService;
        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpPost]
        public ActionResult Create(Products products)
        {
            var response= _productsService.Create(products);
            return Ok(response);
        }
        [HttpGet("{id:int}")]
        public ActionResult GetPost(int id)
        {
            var response= _productsService.GetPost(id);
            return Ok(response);
        }
        [HttpGet] 
        public ActionResult GetAll()
        {
            var response = _productsService.GetAll();
            return Ok(response);
        }
        [HttpDelete("{id:int}")]
        public ActionResult DeletePost(int id)
        {
            var response= _productsService.DeleteProduct(id);
            return Ok();
        }
        [HttpPut("{id:int}")]
        public ActionResult UpdatePost(Products products, int id)
        {
            var response = _productsService.UpdatePost(products, id);
            return Ok();
        }
        // [HttpPut("update/{id:int}")]
        //public ActionResult UpdatePost(int id, [FromForm] Products products, [FromForm] IFormFile image)
        //{
        //    // Resim dosyasını kaydet
        //    if (image != null && image.Length > 0)
        //    {
        //        var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
        //        if (!Directory.Exists(uploadsFolderPath))
        //        {
        //            Directory.CreateDirectory(uploadsFolderPath);
        //        }

        //        var uniqueFileName = Path.GetFileNameWithoutExtension(image.FileName) + "_" + Guid.NewGuid().ToString() + Path.GetExtension(image.FileName);
        //        var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            image.CopyTo(stream);
        //        }

        //        // Ürünün resim dosyası ismini güncelle
        //        products.imgfile = uniqueFileName;
        //    }

        //    // Ürün bilgilerini güncelle
        //    var response = _productsService.UpdatePost(products, id);
        //    return Ok(response);
        //}

        //[HttpPost("upload")]
        //[Consumes("multipart/form-data")]
        //public IActionResult UploadImage([FromForm] IFormFile file)
        //{
        //    // Eğer dosya yoksa hata döndür
        //    if (file == null || file.Length == 0)
        //    {
        //        return BadRequest(new { errors = new { image = new[] { "Yüklemek için bir dosya seçilmedi." } } });
        //    }

        //    // Sunucudaki dizin yolunu belirleyin (örn: wwwroot/images)
        //    var uploadsFolderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

        //    // Eğer dizin yoksa oluştur
        //    if (!Directory.Exists(uploadsFolderPath))
        //    {
        //        Directory.CreateDirectory(uploadsFolderPath);
        //    }

        //    // Benzersiz dosya adını belirle (örneğin: zaman damgası ile)
        //    var uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;

        //    // Dosya yolunu belirleyin
        //    var filePath = Path.Combine(uploadsFolderPath, uniqueFileName);

        //    // Dosyayı belirtilen dizine kaydet
        //    using (var fileStream = new FileStream(filePath, FileMode.Create))
        //    {
        //        file.CopyTo(fileStream);
        //    }

        //    // Başarılı sonuç döndür
        //    return Ok(new { message = "Dosya başarıyla yüklendi.", fileName = uniqueFileName });
        //}

    }
}
