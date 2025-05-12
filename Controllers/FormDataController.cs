using Microsoft.AspNetCore.Mvc;

namespace Week3_Day5.Controllers
{
    public class FormDataController : Controller
    {
        string filePath = "data.txt";
        public IActionResult Index()
        {
            List<string> formData = new List<string>();

            if (System.IO.File.Exists(filePath))
            {
                formData = System.IO.File.ReadAllLines(filePath).ToList();
            }
            else
            {
                formData = new List<string>();
            }
            return View(formData);
        }

        [HttpPost]
        public IActionResult Index(string emailId, string message)
        {
            if (string.IsNullOrWhiteSpace(emailId)==false && string.IsNullOrWhiteSpace(message)==false)
            {
                string newData = $"{emailId}: {message}";
                System.IO.File.AppendAllText(filePath, newData + "\n");
            }
            return RedirectToAction("Index");
        }
    }
}
