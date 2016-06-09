using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace Mvc_WebImage.Controllers
{
    public class ImagemController : Controller
    {
        // GET: Imagem
        public ActionResult Index()
        {
            return View();
        }

        public void GetImagem()
        {
            WebImage wbImage = new WebImage("~/Imagens/Dados_Sistema_Lenovo.png");
            wbImage.Resize(300, 300);
            wbImage.FileName = "quati.jpg";
            wbImage.Write();
        }

        public string ImagePath
        {
            get
            {
                var server = ControllerContext.HttpContext.Server;
                var imagePath = server.MapPath("~/Imagens/quati.jpg");
                return imagePath;
            }
        }

        public void GetCropped()
        {
            new WebImage(ImagePath)
               .Crop(50, 50, 50, 50)  // crop 50px para todos os lados      
               .Write();
        }

        public void GetHorizontalFlip()
        {
            new WebImage(ImagePath)
                .FlipHorizontal()
                .Write();
        }

        public void GetVerticalFlip()
        {
            new WebImage(ImagePath)
                .FlipVertical()
                .Write();
        }

        public void GetResized()
        {
            new WebImage(ImagePath)
                .Resize(500, 500) // redimensiona para 500x500 px      
                .Write();
        }

        public void GetRotateLeft()
        {
            new WebImage(ImagePath)
                .RotateLeft()
                .Write();
        }

        public void GetRotateRight()
        {
            new WebImage(ImagePath)
                .RotateRight()
                .Write();
        }

        public void GetTextWatermark()
        {
            new WebImage(ImagePath)
                .AddTextWatermark("Macoratti .net", "white", 14, "Bold")
                .Write();
        }

        public void GetImageWatermark()
        {
            var watermarkPath = HttpContext.Server.MapPath(@"~/Imagens/marcadagua.jpg");
            var watermark = new WebImage(watermarkPath);
            new WebImage(ImagePath)
                .AddImageWatermark(watermark)
                .Write();
        }
    }
}