using NUnit.Framework;
using AssemblyAnalyzer;

namespace TestProject1
{
    public class BrowserTest
    {

        [Test]
        public void LoadAssemblyTest()
        {
            string filePath = "D:\\VS Projects\\ABCD\\ABCD\\bin\\Debug\\net472\\ABCD.dll";
            AssemblyBrowser browser = new AssemblyBrowser();
            var actual = browser.GetAssemblyInfo(filePath);
            Assert.IsNotNull(actual);
        }

        [Test]
        public void BadFileNameLoadTest()
        {
            string filePath = "sdafasdf";
            AssemblyBrowser browser = new AssemblyBrowser();
            Assert.Throws<System.IO.FileNotFoundException>(() => browser.GetAssemblyInfo(filePath));
        }

    }
}