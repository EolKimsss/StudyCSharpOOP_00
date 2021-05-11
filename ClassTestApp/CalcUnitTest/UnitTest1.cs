using Microsoft.VisualStudio.TestTools.UnitTesting;
using AttributeTestApp;

namespace CalcUnitTest
{
    [TestClass] // ����ڰ� ���°� �ƴ϶� complier�� ���� ���� attribute��
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Myclass myClass = new Myclass();
            int a = 3, b = 5;
            var result = myClass.Plus(a, b);

            Assert.AreEqual(8, result); 
        }
        [TestMethod]
        public void PrintTest()
        {
            Myclass myClass = new Myclass();
            int a = 10, b = 3;
            var result = myClass.Divide(a, b);
            var expected = 3;
            Assert.AreEqual(expected, result);
        }
    }
}
