using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NoteBook
    {
        //Liste de Unit
        private List<Unit> units = new List<Unit>();

        public List<Unit> Units
        {
            get => this.units;

            set
            {
                this.units = value;
            }
        }

        //Liste des examens
        private List<Exam> exams = new List<Exam>();

        public List<Exam> Exams
        {
            get => this.exams;

            set
            {
                this.exams = value;
            }
        }

        /// <summary>
        /// Permet d'obtenir la liste des units
        /// </summary>
        /// <returns>Liste de units</returns>
        public Unit[] ListUnits()
        {
            return this.units.ToArray();
        }

        /// <summary>
        /// Permet d'ajouter une unité
        /// </summary>
        /// <param name="unit"></param>
        public void AddUnit(Unit unit)
        {
            this.units.Add(unit);
        }

        /// <summary>
        /// Permet de supprimer une unité
        /// </summary>
        /// <param name="unit"></param>
        public void RemoveUnit(Unit unit)
        {
            this.units.Remove(unit);
        }

        /// <summary>
        /// Retroune la liste des modules peut importe l'unité
        /// </summary>
        /// <returns></returns>
        public Module[] ListModules()
        {
            List<Module> res = new List<Module>();

            foreach(Unit u in this.units)
            {
                res.AddRange(u.ListModules());
            }

            return res.ToArray();
        }

        /// <summary>
        /// Permet d'ajouter un examen à la liste des examens
        /// </summary>
        /// <param name="e"></param>
        public void AddExam(Exam e)
        {
            this.exams.Add(e);
        }

        /// <summary>
        /// Retourne la liste des examens 
        /// </summary>
        /// <returns></returns>
        public Exam[] ListExams()
        {
            return this.exams.ToArray();
        }

        /// <summary>
        /// Retourne les moyennes par unit d'un notebook
        /// </summary>
        /// <returns></returns>
        public AvgScore[] ComputeScores()
        {
            List<AvgScore> avgScores = new List<AvgScore>();

            float totalScore = 0;
            float totalCoef = 0;

            //On traite Unit par Unit dans la liste des Unit du Notebook
            foreach(Unit u in this.units)
            {
                var listExams = u.ComputeAverage(this.exams.ToArray());
                float score = 0;
                float coef = 0;

                //On traite examen par examen dans la liste des moyenne de l'unit 
                foreach(var e in listExams)
                {
                    score += e.Average * e.PedagogicalName.Coef;
                    coef += e.PedagogicalName.Coef;
                }
                if(coef != 0)
                {
                    float avgScore = score / coef;
                    AvgScore avg = new AvgScore(avgScore, u);
                    avgScores.Add(avg);
                    totalScore += avgScore;
                    totalCoef += u.Coef;
                }
            }

            /* Si le coef global n'est pas nul on regroupe tout dans un nouveau PE */
            if (totalCoef != 0)
            {
                PedagogicalElement generalPE = new PedagogicalElement() { Coef = 1, Name = "generalPE" };
                AvgScore finalAvgScore = new AvgScore(totalScore / totalCoef, generalPE);
                avgScores.Add(finalAvgScore);
            }

            return avgScores.ToArray();
        }
    }
}
 