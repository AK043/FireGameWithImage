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
    public class Form1Tests
    {
        [TestMethod()]
        public void Form1Test()
        {
            Assert.Fail();
        }


        [TestMethod()]
        public void fireCheck() {
            Gun_Shot obj_Gun_Shot = new Gun_Shot();
            obj_Gun_Shot.fire(1, 1, 1);
            
        }

        [TestMethod()]
        public void resetCheck()
        {
            Gun_Shot obj_Gun_Shot = new Gun_Shot();
            obj_Gun_Shot.reset();

        }

    }
}