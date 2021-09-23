using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    class NoteBook
    {
        //Liste de Unit
        private List<Unit> units;

        public List<Unit> Units
        {
            get => this.units;

            set
            {
                this.units = value;
            }
        }

        //Liste des examens
        private List<Exam> exams;

        public List<Exam> Exams
        {
            get => this.exams;

            set
            {
                this.exams = value;
            }
        }

    }
}
