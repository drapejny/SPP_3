using NUnit.Framework;
using AssemblyAnalyzer.Formatters;

namespace TestProject1
{
    public class AnalyzerTest
    {

        [Test]
        public void ClassFormatterTest()
        {
            string actual = ClassFormatter.Format(typeof(A));
            string expected = "public class A";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ConstructorFormatterTest()
        {
            string actual = ConstructorFormatter.Format(typeof(A).GetConstructors()[0]);
            string expected = "public .ctor()";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void FieldFormatterTest()
        {
            string actual = FieldFormatter.Format(typeof(A).GetFields()[0]);
            string expected = "public Int32 a";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void MethodFormatterTest()
        {
            string actual = MethodFormatter.Format(typeof(A).GetMethods()[2]);
            string expected = "public Void met()";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void PropertiesFormatterTest()
        {
            string actual = PropertiesFormatter.Format(typeof(A).GetProperties()[0]);
            string expected = "public Int32 Prop { public get_Prop; public set_Prop; }";
            Assert.AreEqual(expected, actual);
        }

        public class A
        {
            public int a;
            public int Prop { get; set; }

            public A() { }

            public void met() { 
            }
        }
    }
}