using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;

namespace TestLogic
{
    /// <summary>
    /// Classe de test de AvgScore
    /// </summary>
    public class TestAvgScore
    {
        /// <summary>
        /// Test la fonction ToString
        /// </summary>
        [Fact]
        public void testToString()
        {
            Logic.Module module = new Module();
            module.Name = "Math";

            Logic.Exam exam = new Exam();
            exam.Module = module;

            Logic.AvgScore math = new AvgScore(18 , exam.Module);

            Assert.Equal("Nom du module: Math Moyenne: 18", math.ToString());
        }
    }
}
