using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AvgScore
    {
        public AvgScore(float average, PedagogicalElement pe)
        {
            this.pedagogicalName = pe.Name;
            this.average = average;
        }

        private float average;

        public float Average
        {
            get => this.average;

            set
            {
                this.average = value;
            }
        }

        private String pedagogicalName;

        public String PedagogicalName
        {
            get => this.pedagogicalName;
            set
            {
                this.pedagogicalName = value;
            }
        }

        //Retourne la note moyenne ainsi que la nom de l'élément
        public override String ToString()
        {
            return "Nom du module: " + this.pedagogicalName + " Moyenne: " + this.average.ToString();
        }
    }
}
