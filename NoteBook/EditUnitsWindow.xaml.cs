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
using Logic;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour EditUnitsWindow.xaml
    /// </summary>
    public partial class EditUnitsWindow : Window
    {
        public EditUnitsWindow(Logic.NoteBook notebook)
        {
            InitializeComponent();
            this.notebook = notebook;
            this.DrawUnits();
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
        /// Permet de charger les units dans le tableau d'affichage
        /// </summary>
        private void DrawUnits()
        {
            var list = this.notebook.ListUnits();
            units.Items.Clear();

            foreach (var item in list)
                units.Items.Add(item);
        }

        /// <summary>
        /// PErmet de double click une unit pour l'éditer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditUnit(object sender, MouseButtonEventArgs e)
        {
            if (units.SelectedItem is Unit u)
            {
                EditElementWindow third = new EditElementWindow(u);
                if (third.ShowDialog() == true)
                {
                    DrawUnits();
                }
            }

        }

        /// <summary>
        /// Permet d'ajouter une unit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addUnit(object sender, RoutedEventArgs e)
        {
            try
            {
                Unit newUnit = new Unit();
                EditElementWindow third = new EditElementWindow(newUnit);
                if (third.ShowDialog() == true)
                {
                    notebook.AddUnit(newUnit);
                    DrawUnits();
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
