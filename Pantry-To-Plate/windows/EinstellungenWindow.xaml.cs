using Pantry_To_Plate.mods;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Pantry_To_Plate.windows
{
    /// <summary>
    /// Interaktionslogik für EinstellungenWindow.xaml
    /// </summary>
    public partial class EinstellungenWindow : Window
    {
        public EinstellungenWindow()
        {
            InitializeComponent();
            
        }

        public userinfo userinfo;
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                string input = Gewichteingabe.Text;
                userinfo.Weight = double.Parse(input);
            }
            catch { }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            try
            {
                string input = größeeingabe.Text;
                userinfo.Height = double.Parse(input);
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        // rechnen button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double ans = userinfo.KcalZielBerechnen(userinfo.Weight, userinfo.Height, userinfo.diätzielChoice, userinfo.Genderchoice, userinfo.Age);
            ziel.Text = $"{ans}";

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (diätzielCombo.SelectedItem == abnehmenComboans)
            {
                userinfo.diätzielChoice = 3;

            }
            if (diätzielCombo.SelectedItem == haltenComboans)
            {
                userinfo.diätzielChoice = 2;

            }
            if (diätzielCombo.SelectedItem == zunehmenComboans)
            {
                userinfo.diätzielChoice = 1;
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (AlltagCombo.SelectedItem == LPal)
            {
                userinfo.palWert = 0.95;

            }
            if (AlltagCombo.SelectedItem == MLPal)
            {
                userinfo.palWert = 1.2;

            }
            if (AlltagCombo.SelectedItem == NSPal)
            {
                userinfo.palWert = 1.5;
            }
            if (AlltagCombo.SelectedItem == ÜSPal)
            {
                userinfo.palWert = 1.7;
            }
            if (AlltagCombo.SelectedItem == VSGPal)
            {
                userinfo.palWert = 1.9;
            }
            if (AlltagCombo.SelectedItem == VKPal)
            {
                userinfo.palWert = 2;
            }
            
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            try
            {
                string input = ageans.Text;

                userinfo.Age = double.Parse(input);

            }

            catch
            {
                ageans.Background = Brushes.Red;

            }
        }

        private void ComboBox_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            if (Geschlechtcombo.SelectedItem == femc)
            {
                userinfo.Genderchoice = 1;
            }
            if (Geschlechtcombo.SelectedItem == malec)
            {
                userinfo.Genderchoice = 2;
            }
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }
    }
}
