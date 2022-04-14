using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest.Tests {
    [TestClass()]
    public class PlayBoardTests {
        [TestMethod()]
        public void initArgsTest() {
            string[] value = { "1", "2", "3", "4" };
            PlayBoard test=new PlayBoard();
            bool res = test.initArgs(value);
            Assert.IsTrue(res);
        }

        

    }
}