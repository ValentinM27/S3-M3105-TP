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

        [Fact]
        public void TestAddModules()
        {
            Unit unit = new Unit();
            unit.Name = "Test";
            unit.Coef = 1;

            Module module = new Module();
            module.Name = "TestM";
            module.Coef = 3;

            unit.Add(module);

            List<Module> listModule = new List<Module>();
            listModule.Add(module);
            Module[] tableModule = listModule.ToArray();

            Assert.Equal(tableModule, unit.ListModules());
        }
    }
}
