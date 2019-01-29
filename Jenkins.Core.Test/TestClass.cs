using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins.Core.Test
{
	[TestFixture]
	public class TestClass
	{
		[Test]
		public void TestHelloWorld()
		{
			Assert.Pass(HelloWolrdHelper.GetString());
        }
        [Test]
        public void TestSucceeded()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void TestSucceeded2()
        {
            Assert.IsTrue(true);
        }
    }
}
