using AuthSys.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace AuthSys.Controllers
{
    public class Files1Controller : Controller
    {
        IHostingEnvironment _hostingEnvironment = null;
        
        public Files1Controller(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }


        [HttpGet]
        public IActionResult CNLA_InnersRisk(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }

            return View(fileObj);
        }

        [HttpPost]
        public IActionResult CNLA_InnersRisk(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();

            }
            return CNLA_InnersRisk();
        }

        [HttpGet]
        public IActionResult CNLA_InnersExterior(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }



            return View(fileObj);
        }

        [HttpPost]
        public IActionResult CNLA_InnersExterior(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();

            }
            return CNLA_InnersExterior();
        }

        [HttpGet]
        public IActionResult CNLA_InnersLeadership(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }



            return View(fileObj);
        }

        [HttpPost]
        public IActionResult CNLA_InnersLeadership(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();

            }
            return CNLA_InnersLeadership();
        }

        public IActionResult PDFViewerNewTab(string fileName)
        {
            string path = _hostingEnvironment.WebRootPath + "\\files\\" + fileName;
            return File(System.IO.File.ReadAllBytes(path), "application/pdf");
        }

        [HttpGet]
        public IActionResult UploadPdfs(string fileName = "")
        {
            FileClass fileObj = new FileClass();
            fileObj.Name = fileName;

            string path = $"{_hostingEnvironment.WebRootPath}\\files\\";
            int nId = 1;

            foreach (string pdfPath in Directory.EnumerateFiles(path, "*.pdf"))
            {
                fileObj.Files.Add(new FileClass()
                {
                    FileId = nId++,
                    Name = Path.GetFileName(pdfPath),
                    Path = pdfPath
                });
            }

            return View(fileObj);
        }

        [HttpPost]
        public IActionResult UploadPdfs(IFormFile file, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            string fileName = $"{hostingEnvironment.WebRootPath}\\files\\{file.FileName}";
            using (FileStream fileStream = System.IO.File.Create(fileName))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();

            }
            return UploadPdfs();
        }

       
    }
}
