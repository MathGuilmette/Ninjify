using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ninjify.Models;
using Ninjify.Controllers;
using Ninjify.Scripts;

namespace Ninjify.Tests
{
    [TestClass]
    public class UnitTest1
    {
       [TestMethod]
       public void GetNinjaName_ShouldReturnSame()
       {
            Algorithm algo = new Algorithm();
            string ninjaName1 = algo.WordToNinja("Richard Turbo");
            string ninjaName2 = algo.WordToNinja("Richard Turbo");

            Assert.AreEqual(ninjaName1, ninjaName2);
        }
    }
}
