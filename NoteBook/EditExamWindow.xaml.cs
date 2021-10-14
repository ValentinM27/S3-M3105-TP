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
    /// Logique d'interaction pour EditExamWindow.xaml
    /// </summary>
    public partial class EditExamWindow : Window
    {
        private Logic.NoteBook notebook;
        public EditExamWindow(Logic.NoteBook nb)
        {
            InitializeComponent();
            this.notebook = nb;
            DrawModules(this.notebook.ListModules());
            this.notebook.ListModules().ToString();
            
        }
         
        /// <summary>
        /// Permet d'initialiser la liste des modules
        /// </summary>
        /// <param name="m"></param>
        private void DrawModules(Logic.Module[] m)
        {
            foreach(Logic.Module module in m)
            {
                moduleSelect.Items.Add(module);
            }
        }

        /// <summary>
        /// Permet de valider l'ajout d'un module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Validate(object sender, RoutedEventArgs e)
        {
            try
            {
                Logic.Exam exam = new Logic.Exam();

                exam.Score = (float)Convert.ToDouble(scoreBox.Text);
                exam.DateTime = datePicker.SelectedDate.Value;
                exam.Teacher = teacherBox.Text;
                exam.Module = moduleSelect.SelectedItem as Logic.Module;
                exam.IsAbsent = absentCheck.IsChecked.Value;
                exam.Coef = (float)Convert.ToDouble(coefBox.Text);

                this.notebook.AddExam(exam);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Permet de fermer la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
