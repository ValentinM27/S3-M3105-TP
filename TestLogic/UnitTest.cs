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


        /// <summary>
        /// Test de addModules
        /// </summary>
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

        /// <summary>
        /// Test la fonction computeAverage
        /// </summary>
        [Fact]
        public void TestComputeAverage()
        {
            Logic.Unit unit1 = new Unit() { Name = "UE1", Coef = 14 };
            Logic.Module module1 = new Module() { Name = "Science des droits sociaux", Coef = 13 };

            Logic.Exam exam1 = new Exam() { Module = module1, Coef = 9, Score = 17 };
            Logic.Exam exam2 = new Exam() { Module = module1, Coef = 7, Score = 18 };

            Logic.Module module2 = new Module() { Name = "Problèmes économiques contemporains", Coef = 13 };
            Logic.Exam exam3 = new Exam() { Module = module2, Coef = 5, Score = 19 };
            Logic.Exam exam4 = new Exam() { Module = module2, Coef = 6, Score = 16 };

            List<Logic.Exam> exams = new List<Exam>() { exam1, exam2, exam3, exam4 };

            float AverageScoreModule1 = (9f * 17f + 7f * 18f) / 16f;
            float AverageScoreModule2 = (5f * 19f + 6f * 16f) / 11f;

            unit1.Add(module1);
            unit1.Add(module2);

            var ListAvgScore = unit1.ComputeAverage(exams.ToArray());
            Assert.NotNull(ListAvgScore);
            //On test que il n'y a que deux module dans la liste
            Assert.Equal(2, ListAvgScore.Length);
            // Comparaison des moyennes 
            Assert.Equal(AverageScoreModule1, ListAvgScore[0].Average, 3);
            Assert.Equal(AverageScoreModule2, ListAvgScore[1].Average, 3);
        }
    }
}
