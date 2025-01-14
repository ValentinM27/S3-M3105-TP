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
using System.Windows.Shapes;
using Logic;

namespace NoteBook
{
    /// <summary>
    /// Logique d'interaction pour EditUnitsWindow.xaml
    /// </summary>
    public partial class EditUnitsWindow : Window
    {
        public EditUnitsWindow(Logic.NoteBook notebook, Logic.IStorage storage)
        {
            InitializeComponent();
            this.notebook = notebook;
            this.DrawUnits();
            this.storage = storage;
        }

        private Logic.IStorage storage;

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
                    this.storage.Save(Notebook);
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
                    this.storage.Save(notebook);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        /// <summary>
        /// Permet de supprimer une unité
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveUnit(object sender, RoutedEventArgs e)
        {
            try
            {
                if (units.SelectedItem is Unit unit)
                {
                    notebook.RemoveUnit(unit);
                    DrawUnits();
                    this.storage.Save(notebook);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        /// <summary>
        /// Permet d'afficher la liste des modules
        /// </summary>
        private void DrawModules()
        {
            if(units.SelectedItem is Unit unit)
            {
                var list = unit.ListModules();
                modulesList.Items.Clear();

                foreach(Module m in list)
                {
                    modulesList.Items.Add(m);
                }
            }
        }

        private void units_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DrawModules();
        }

        /// <summary>
        /// Permet de modifier un modules
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditModules(object sender, MouseButtonEventArgs e)
        {
            if (modulesList.SelectedItem is Module m)
            {
                EditElementWindow third = new EditElementWindow(m);
                if (third.ShowDialog() == true)
                {
                    DrawUnits();
                    this.storage.Save(notebook);
                }
            }
        }

        /// <summary>
        /// Permet de créer un module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateModule(object sender, RoutedEventArgs e)
        {
            try
            {
                Module newModule = new Module();
                EditElementWindow third = new EditElementWindow(newModule);
                if (third.ShowDialog() == true)
                {
                    if (units.SelectedItem is Unit unit)
                    {
                        unit.Add(newModule);
                    }                    
                    DrawUnits();
                    this.storage.Save(notebook);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        /// <summary>
        /// Permet de supprimer un module
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove(object sender, RoutedEventArgs e)
        {
            try
            {
                if (units.SelectedItem is Unit unit)
                {
                    if (modulesList.SelectedItem is Module module)
                    {
                        unit.Remove(module);
                    }
                    DrawUnits();
                    this.storage.Save(notebook);
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
