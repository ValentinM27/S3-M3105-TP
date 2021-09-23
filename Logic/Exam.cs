using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Sert à gérer les examens
    /// </summary>
    public class Exam
    {
        private Module module;

        //Nom de l'enseignant
        private String teacher;

        public String Teacher
        {
            get => this.teacher;
            
            set
            {
                if (value == null || value == "") throw new Exception("Teacher");
                this.teacher = value;
            }
        }

        //Date de l'examen
        private DateTime dateTime;

        public DateTime DateTime
        {
            get => this.dateTime;

            set
            {
                this.dateTime = value;
            }
        }

        //Coef de l'examen
        private float coef;

        public float Coef
        {
            get => this.coef;

            set
            {
                if (value < 0) throw new Exception("Coef mut be >= 0");
                this.coef = value;
            }
        }

        //Est absent?
        private Boolean isAbsent;

        public Boolean IsAbsent
        {
            get => this.isAbsent;

            set
            {
                this.isAbsent = value;
                if(value == false)
                {
                    this.Score = 0;
                }
            }
        }

        //Score à l'examen 
        private float score;

        public float Score
        {
            get => this.score;

            set
            {
                if (value < 0 || value > 20) throw new Exception("Score must be between 0 and 20");
                this.score = value;
            }
        }
    }
}
