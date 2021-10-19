using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Gère les modules
    /// </summary>
    public class Module : PedagogicalElement
    {

        /// <summary>
        /// Permet d'obbtenir la moyenne du module en fonction de tout les exams de ce module
        /// </summary>
        /// <param name="exams"></param>
        /// <returns></returns>
        public AvgScore ComputeAverage(Exam[] exams)
        {
            AvgScore average = null;

            float score = 0;
            float coef = 0;

            foreach(Exam e in exams)
            {
                if(e.Module == this)
                {
                    score += e.Score * e.Coef;
                    coef += e.Coef;
                }
            }
            if(coef != 0)
            {
                average = new AvgScore(score / coef, this);
            }

            return average;
        }
    }
}
