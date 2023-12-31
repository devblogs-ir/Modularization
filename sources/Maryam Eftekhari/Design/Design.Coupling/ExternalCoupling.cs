using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Design.Coupling
{
    public partial class Check
    {
        public string Image { get; set; }
        public IFormFile ImageFile { get; set; }
    }

    [ApiController]
    public class ChecksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(Check check) 
        {
            //Do get check
            return Ok();
        }

        // External coupling happens when send request delete and display a file at the same time 
        [HttpPut]
        public async Task<IActionResult> UpdateAsync(Check check)
        {
            // Do update check
            if (check.ImageFile != null)
            {
                DeleteFile(check.Image, "Images");
                check.Image = await CreateFileAsync(check.ImageFile, "Images");
            }

            return Ok();
        }

        private async Task<string> CreateFileAsync(IFormFile file,string fileFolder)
        {
            string fileName = Guid.NewGuid().ToString() + "_" + file.FileName;
            var currentPath = Path.Combine(Directory.GetCurrentDirectory(),
                fileFolder,
                fileName);
            using (var stream = new FileStream(currentPath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return fileName;
        }
        private void DeleteFile(string fileName, string fileFolder)
        {
            var currentPath = Path.Combine(Directory.GetCurrentDirectory(),
            fileFolder,
            fileName);
            System.IO.File.Delete(currentPath);
        }
    }
}
