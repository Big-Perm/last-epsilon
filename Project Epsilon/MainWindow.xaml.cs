﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Project_Epsilon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            //Add Machines for Demo Purposes

        }


        private void RecipeEditorBtn_Click(object sender, RoutedEventArgs e)
        {
            //creates new instance of recipe input page and displays it
            RecipeInput RecipeInput = new RecipeInput();
            RecipeInput.Show();
        }

        private void SettingsBtn_Click(object sender, RoutedEventArgs e)
        {
            ConnectionManagerWindow connectionManagerWindow = new ConnectionManagerWindow();
            connectionManagerWindow.Show();
            
        }

        private void Exit(object sender, RoutedEventArgs e)
        {
            //when button pressed, closes the app
            Application.Current.Shutdown();
        }

        private void RecipesBtn_Click(object sender, RoutedEventArgs e)
        {
            //creates new instance of connection manager page and displays it
            if (LoadedRecipe.recipeloaded == false)
            {
                FileBrowser winFileBrowser = new FileBrowser();
                winFileBrowser.Show();
            }
            else
            {
                MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Resume previous recipe?", "Confirm", System.Windows.MessageBoxButton.YesNo);
                if (messageBoxResult == MessageBoxResult.Yes)
                {
                    RecipeInput winRecipeInput = new RecipeInput();
                    winRecipeInput.Show();
                    
                }
                else
                {
                    FileBrowser winFileBrowser = new FileBrowser();
                    winFileBrowser.Show();
                    
                }
            }
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }       
    }
}
