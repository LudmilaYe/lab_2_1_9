using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_2_1_9;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_1_9.Tests {
  [TestClass()]
  public class ProgramTests {
    [TestMethod()]
    public void GetMultipliedTwoMinNumsTest1() {
      Assert.AreEqual("-5*3=-15", Form1.GetMultipliedTwoMinNums(new int[] { -5, 3, 5 }));
    }
    [TestMethod()]
    public void GetMultipliedTwoMinNumsTest2() {
      Assert.AreEqual("-5*0=0", Form1.GetMultipliedTwoMinNums(new int[] { 5555, 0, -5 }));
    }
    [TestMethod()]
    public void GetMultipliedTwoMinNumsTest3() {
      Assert.AreEqual("-555*-55=30525", Form1.GetMultipliedTwoMinNums(new int[] { -5, -55, -555 }));
    }
  }
}
