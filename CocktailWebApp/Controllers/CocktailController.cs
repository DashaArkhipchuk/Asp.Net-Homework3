using CocktailsLibrary;
using CocktailWebApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading;

namespace CocktailWebApp.Controllers
{
    public class CocktailController : Controller
    {
        private readonly ICocktailRepository _cocktailService;

        public CocktailController(ICocktailRepository cocktailService)
        {
            this._cocktailService = cocktailService;

            IOutputInfo printer = new OutputInfo();
            this._cocktailService.AddCocktail(new Cocktail1(printer));
            this._cocktailService.AddCocktail(new Cocktail2(printer));
        }

        public IActionResult Index()
        {
            return View(this._cocktailService.GetCocktails());
        }

        public IActionResult ExportDataToTxtFile()
        {
            string filename="cocktails.txt";
            try
            {
                if (!System.IO.File.Exists(filename))
                {
                    System.IO.File.Create(filename).Close();
                }
                else
                {
                    System.IO.File.WriteAllText(filename, string.Empty);
                }

                this._cocktailService.SaveCocktailsInfoToTxt(filename);
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to create file: {ex.Message}");
            }

            var fileName = "cocktails.txt";
            var mimeType = "text/plain";

            var fileBytes = System.IO.File.ReadAllBytes(filename);
            return File(fileBytes, mimeType, fileName);
        }
    }
}
