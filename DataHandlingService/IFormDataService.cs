namespace Week3_Day5.DataHandlingService
{
    public interface IFormDataService
    {
        List<string> Read();
        void Save(string emailId, string message);
    }
}
