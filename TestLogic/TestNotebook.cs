using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Logic;

namespace TestLogic
{
    public class TestNotebook
    {
        //Test les contrainte de Name
        [Fact]
        public void TestListUnits()
        {
            Logic.NoteBook notebook = new Logic.NoteBook();

            List<Logic.Unit> testingList = new List<Logic.Unit>();
            notebook.Units = testingList;

            Unit[] res = notebook.ListUnits();

            Assert.Equal(res, notebook.ListUnits());
        }
    }
}
