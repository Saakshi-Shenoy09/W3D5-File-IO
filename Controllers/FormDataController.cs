using Microsoft.AspNetCore.Mvc;
using Week3_Day5.DataHandlingService;

namespace Week3_Day5.Controllers
{
    public class FormDataController : Controller
    {
        private readonly IFormDataService _formDataService;

        public FormDataController(IFormDataService formDataService)
        {
            _formDataService = formDataService;
        }
        public IActionResult Index()
        {
            List<string> formData = _formDataService.Read();
            return View(formData);
        }

        [HttpPost]
        public IActionResult Index(string emailId, string message)
        {
            _formDataService.Save(emailId, message);
            return RedirectToAction("Index");
        }
    }
}
