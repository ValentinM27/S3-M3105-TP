using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;

namespace TestLogic
{
    public class TestModule
    {

        /// <summary>
        /// Permet de tester la fonction ComputeAverage
        /// </summary>
        [Fact]
        public void TestComputeAverage()
        {
            Module module = new Module();

            Exam exam1 = new Exam() { Module = module, Coef = 5, Score = 15 };
            Exam exam2 = new Exam() { Module = module, Coef = 10, Score = 20 };

            List<Exam> listeExam = new List<Exam> { exam1, exam2 };

            Assert.NotNull(module.ComputeAverage(listeExam.ToArray()));

            AvgScore averageScore = module.ComputeAverage(listeExam.ToArray());

            float avg = (5f * 15f + 10f * 20f) / 15f;
            Assert.Equal(avg, averageScore.Average , 2);
        }
    }
}
