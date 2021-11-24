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

        [Test]
        public void AssemblyNamespacesTest()
        {
            string filePath = "D:\\VS Projects\\ABCD\\ABCD\\bin\\Debug\\net472\\ABCD.dll";
            AssemblyBrowser browser = new AssemblyBrowser();
            var assemblyInfo = browser.GetAssemblyInfo(filePath);
            int actual = assemblyInfo.Count;
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AssemblyClassesTest()
        {
            string filePath = "D:\\VS Projects\\ABCD\\ABCD\\bin\\Debug\\net472\\ABCD.dll";
            AssemblyBrowser browser = new AssemblyBrowser();
            var assemblyInfo = browser.GetAssemblyInfo(filePath);
            int actual = assemblyInfo[0].Members.Count;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AssemblyClassMembersTest()
        {
            string filePath = "D:\\VS Projects\\ABCD\\ABCD\\bin\\Debug\\net472\\ABCD.dll";
            AssemblyBrowser browser = new AssemblyBrowser();
            var assemblyInfo = browser.GetAssemblyInfo(filePath);
            int actual = assemblyInfo[0].Members[0].Signature.Split("\n").Length;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

    }
}