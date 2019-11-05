using System;
using System.Reflection;

namespace ConsoleApplication1
{
    public class SimpleParserTests
    {
        public static void TestReturnZeroWhenEmptyString()
        {
            string testName = MethodBase.GetCurrentMethod().Name;
            try
            {
                SimpleParser p = new SimpleParser();
                int result = p.ParseAndSum(string.Empty);
                if (result != 0)
                {
                    TestUtil.ShowProblem(testName, " Parse and sum should have returned 0 on an empty string");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
