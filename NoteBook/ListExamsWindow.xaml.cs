using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour ListExamsWindow.xaml
    /// </summary>
    public partial class ListExamsWindow : Window
    {
        public ListExamsWindow(Logic.NoteBook notebook)
        {
            InitializeComponent();
            this.notebook = notebook;
            DrawExams();
        }

        private Logic.NoteBook notebook;

        public Logic.NoteBook Notebook
        {
            get => this.notebook;

            set
            {
                this.notebook = value;
            }
        }

        /// <summary>
        ///Permet de remplir la liste des examens
        /// </summary>
        private void DrawExams()
        {
            exams.Items.Clear();
            foreach(Logic.Exam e in this.notebook.ListExams())
            {
                exams.Items.Add(e);
            }

            scores.Items.Clear();
            foreach(Logic.AvgScore avg in notebook.ComputeScores())
            {
                scores.Items.Add(avg);
            }
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
