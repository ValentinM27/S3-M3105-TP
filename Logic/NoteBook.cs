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

        public void AddUnit(Unit unit)
        {
            this.units.Add(unit);
        }
    }
}
 