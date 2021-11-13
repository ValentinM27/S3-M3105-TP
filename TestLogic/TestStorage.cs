using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;
using Storage;


namespace TestLogic
{
    /// <summary>
    /// Classe de test de storage
    /// </summary>
    public class TestStorage
    {
        /// <summary>
        /// Test des fonctions de sauvegarde et de chargement
        /// </summary>
        [Fact]
        public void testSaveAndLoad()
        {
            Logic.NoteBook notebook = new Logic.NoteBook();

            Logic.Unit UE1 = new Logic.Unit();
            UE1.Name = "UE1";
            UE1.Coef = 13;
            notebook.AddUnit(UE1);

            Logic.Unit UE2 = new Logic.Unit();
            UE2.Name = "UE2";
            UE2.Coef = 12;
            notebook.AddUnit(UE2);

            Logic.Module module1 = new Logic.Module() { Name = "M3105", Coef = 3.5f };
            Logic.Module module2 = new Logic.Module() { Name = "M3106", Coef = 2.5f };
            UE1.Add(module1);  UE1.Add(module2);

            Logic.Module module3 = new Logic.Module() { Name = "M3201", Coef = 2.5f };
            Logic.Module module4 = new Logic.Module() { Name = "M3102", Coef = 2.5f };
            UE2.Add(module3); UE2.Add(module4);


            Logic.Exam exam1 = new Logic.Exam() { Module = module2 , DateTime = System.DateTime.Now };
            Logic.Exam exam2 = new Logic.Exam() { Module = module4 , DateTime = System.DateTime.Now };
            notebook.AddExam(exam1); notebook.AddExam(exam2);

            Storage.JsonStorage jsonStorage = new Storage.JsonStorage("notebook1.json");
            jsonStorage.Save(notebook);


            NoteBook res = jsonStorage.Load();

            Assert.Equal(res.ListExams(), notebook.ListExams());
            Assert.Equal(res.ListModules(), notebook.ListModules());
            Assert.Equal(res.ListUnits(), notebook.ListUnits());
        }
    }
}
