using System.IO;

namespace Week3_Day5.DataHandlingService
{
    public class FormDataService : IFormDataService
    {
        string filePath = "data.txt";
        public List<string> Read()
        {
            List<string> formData = new List<string>();
            if (File.Exists(filePath))
            {
                formData = System.IO.File.ReadAllLines(filePath).ToList();
                return formData;
            }
            else
            {
                return new List<string>();
            }
        }

        public void Save(string emailId, string message)
        {
            if (string.IsNullOrWhiteSpace(emailId)==false && string.IsNullOrWhiteSpace(message)==false)
            {
                string newData = $"{emailId}: {message}";
                System.IO.File.AppendAllText(filePath, newData + "\n");
            }
        }
    }
}
