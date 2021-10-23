using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;

namespace TestLogic
{
    public class TestNotebook
    {
        //Test ListUnits()
        [Fact]
        public void TestListUnits()
        {
            Logic.NoteBook notebook = new Logic.NoteBook();

            List<Logic.Unit> testingList = new List<Logic.Unit>();
            notebook.Units = testingList;

            Unit[] res = notebook.ListUnits();

            Assert.Equal(res, notebook.ListUnits());
        }

        //Test l'ajout d'une unité
        [Fact]
        public void TestAddUnit()
        {

            Logic.NoteBook notebook = new Logic.NoteBook();

            Logic.Unit unit = new Logic.Unit();

            unit.Name = "UE1";
            unit.Coef = 8;

            notebook.AddUnit(unit);

            List<Unit> temp = new List<Unit>();
            temp.Add(unit);
            Unit[] res = temp.ToArray();

            Assert.Single(notebook.ListUnits());

            Assert.Equal(res, notebook.ListUnits());
        }


        //Test la suppression d'une unité
        [Fact]
        public void TestRemoveUnit()
        {

            Logic.NoteBook notebook = new Logic.NoteBook();

            Logic.Unit unit = new Logic.Unit();

            unit.Name = "UE1";
            unit.Coef = 8;

            notebook.AddUnit(unit);

            List<Unit> temp = new List<Unit>();
            temp.Add(unit);
            Unit[] res = temp.ToArray();

            //On test l'ajout de l'unit
            Assert.Equal(res, notebook.ListUnits());

            notebook.RemoveUnit(unit);

            Unit[] emptyRes = { };

            //On test la suppression de l'unit 
            Assert.Equal(emptyRes, notebook.ListUnits());
        }

        //Test la fonction ListModule 
        [Fact]
        public void TetsListModule()
        {
            Logic.NoteBook notebook = new NoteBook();
            Logic.Unit unit = new Unit();

            unit.Name = "UE1";
            unit.Coef = 8;

            Logic.Module module = new Module();
            module.Name = "Programmation";
            module.Coef = 10;   

            unit.Add(module);

            notebook.AddUnit(unit);

            Module[] test = unit.ListModules();
            
            Assert.Equal(test, notebook.ListModules());

        }

        //Test la fonction AddExam
        [Fact]
        public void TestAddExam()
        {
            Logic.NoteBook notebook = new NoteBook();
            Logic.Exam exam = new Exam();

            notebook.AddExam(exam);
            Assert.Single(notebook.Exams);
        }

        /// <summary>
        /// Test de listExams
        /// </summary>
        [Fact]
        public void TestListExam()
        {
            Logic.NoteBook notebook = new NoteBook();
            Logic.Exam exam = new Exam();

            notebook.Exams.Add(exam);

            Assert.Single(notebook.ListExams());
            Assert.Equal(notebook.Exams, notebook.ListExams());
        }

        /// <summary>
        /// Test la fonction ComputeAverage 
        /// </summary>
        [Fact]
        public void testComputeAverage()
        {
            Logic.NoteBook notebook = new NoteBook();

            Logic.Unit unit1 = new Unit() { Coef = 6, Name = "Unit1" };
            Logic.Module module1 = new Module() { Coef = 2, Name = "Gestion" };

            Logic.Exam exam1 = new Exam() { Coef = 2, Module = module1, Score = 20 };
            Logic.Exam exam2 = new Exam() { Coef = 3.5f, Module = module1, Score = 18 };

            Logic.Module module2 = new Module() { Coef = 5, Name = "Institution Politique" };
            Logic.Exam exam3 = new Exam() { Coef = 8, Module = module2, Score = 17 };
            Logic.Exam exam4 = new Exam() { Coef = 5, Module = module2, Score = 14 };

            unit1.Add(module1);
            unit1.Add(module2);

            notebook.AddUnit(unit1);
            notebook.AddExam(exam1);
            notebook.AddExam(exam2);
            notebook.AddExam(exam3);
            notebook.AddExam(exam4);
        }
    }
}
