using System;
using Xunit;
using Logic;
using System.Collections.Generic;

namespace TestLogic
{
    public class UnitTest
    {
        /// <summary>
        /// Test ListModules 
        /// </summary>
        [Fact]
        public void TestListModules()
        {
            Unit unit = new Unit();

            List<Module> listeModules = new List<Module>();

            Module[] resModules = listeModules.ToArray();

            Assert.Equal(resModules, unit.ListModules());
        }
    }
}
