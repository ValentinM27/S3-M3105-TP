﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Logic;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.notebook = new Logic.NoteBook();
            InitializeComponent();
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

        private void GoEditUnits(object sender, RoutedEventArgs e)
        {
            EditUnitsWindow second = new EditUnitsWindow(this.notebook) ;
            second.Show();
        }
    }
}
