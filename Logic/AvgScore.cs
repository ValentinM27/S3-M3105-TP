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
            this.pedagogicalName = pe;
            this.average = average;
        }

        private float average;

        public float Average
        {
            get => this.average;
        }

        private PedagogicalElement pedagogicalName;

        public PedagogicalElement PedagogicalName
        {
            get => this.pedagogicalName;
        }

        //Retourne la note moyenne ainsi que la nom de l'élément
        public override String ToString()
        {
            return "Nom du module: " + this.pedagogicalName.Name + " Moyenne: " + this.average.ToString();
        }
    }
}
