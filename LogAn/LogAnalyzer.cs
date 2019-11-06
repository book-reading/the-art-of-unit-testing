namespace LogAn
{
    public class LogAnalyzer
    {
        public bool IsValidLogFileName(string fileName)
        {
            if (fileName.EndsWith(".SLF"))
            {
                return true;
            }
            return false;
        }
    }
}
