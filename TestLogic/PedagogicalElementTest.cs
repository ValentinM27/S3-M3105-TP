using System;
using Xunit;
using Logic;

namespace TestLogic
{
    public class PedagogicalElementTest
    {
        //Test les contrainte de Name
        [Fact]
        public void TestTeacherNull() { 
            Assert.Throws<Exception>(() => {
                PedagogicalElement p = new PedagogicalElement();
                p.Name = null;
            });
        }

        [Fact]
        public void TestTeacherEmpty()
        {
            Assert.Throws<Exception>(() => {
                PedagogicalElement p = new PedagogicalElement();
                p.Name = "";
            });
        }

        //Test des contraintes de coef 
        [Fact]
        public void TestCoef()
        {
            Assert.Throws<Exception>(() =>
            {
                PedagogicalElement p = new PedagogicalElement();
                p.Coef = -1;
            });
        }
    }
}
