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

            notebook.addUnit(unit);

            List<Unit> temp = new List<Unit>();
            temp.Add(unit);
            Unit[] res = temp.ToArray();

            Assert.Equal(2, notebook.ListUnits().Length);

            Assert.Equal(res, notebook.ListUnits());

        }
    }
}
