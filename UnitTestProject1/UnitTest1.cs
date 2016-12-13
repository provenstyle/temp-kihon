using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FooTest : FooTestBase
    {
        protected override bool Return_true()
        {
            return true;
        }

        protected override string Return_hello_world()
        {
            return "Hello World";
        }
    }

    public abstract class FooTestBase
    {
        [TestMethod]
        public void Execute_Return_true()
        {
            Assert.IsTrue(Return_true());
        }

        [TestMethod]
        public void Execute_Return_Hello_World()
        {
            Assert.AreEqual("Hello World", Return_hello_world());
        }

        protected abstract bool Return_true();

        protected abstract string Return_hello_world();
    }
}
