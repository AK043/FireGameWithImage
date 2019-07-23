using Microsoft.VisualStudio.TestTools.UnitTesting;
using FireGameWithImage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGameWithImage.Tests
{
    [TestClass()]
    public class Gun_ShotTests
    {
        [TestMethod()]
        public void fireTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void reset() {
            Gun_Shot obj_gun_Shot = new Gun_Shot();
            obj_gun_Shot.reset();
        }
    }
}