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
    /// Logique d'interaction pour EditElementWindow.xaml
    /// </summary>
    public partial class EditElementWindow : Window
    {
        public EditElementWindow(PedagogicalElement elt)
        {
            InitializeComponent();
            this.element = elt;
            nameBox.Text = element.Name;
            coefBox.Text = element.Coef.ToString();
        }

        private PedagogicalElement element;

        public PedagogicalElement Element
        {
            get => this.element;

            set
            {
                this.element = value;
            }
        }

        private void Validate(object sender, RoutedEventArgs e)
        {
            try
            {
                element.Name = nameBox.Text;
                element.Coef = (float)Convert.ToDouble(coefBox.Text);
                DialogResult = true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }
    }
}
