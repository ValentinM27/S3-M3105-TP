using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Classe gérant les matières
    /// </summary>
    public class PedagogicalElement
    {
        //Nom de la matière
        private String name;

        public String Name
        {
            get => this.name;

            set
            {
                if (value == null || value == "") throw new Exception("The name must be entered");
                this.name = value;
            }
        }

        //Coeficient de la matière
        private float coef;

        public float Coef
        {
            get => this.coef;

            set
            {
                if (value <= 0) throw new Exception("The coef must be >0");
                this.coef = value;
            }

        }

        public override string ToString()
        {
            return this.name + " ("+this.coef+") ";
        }
    }
}
