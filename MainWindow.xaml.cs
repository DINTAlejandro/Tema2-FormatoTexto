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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tema2_FormatoTexto
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            negro_RadioButton.IsChecked = true;
        }

        private void entrada_TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            salida_TextBlock.Text =  entrada_TextBox.Text;
        }

        private void negro_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.Foreground = Brushes.Black;
        }
        private void azul_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.Foreground = Brushes.Blue;
        }

        private void rojo_RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.Foreground = Brushes.Red;
        }

        private void negrita_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontWeight = FontWeights.Bold;
        }

        private void negrita_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontWeight = FontWeights.Normal;
        }

        private void curisva_CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontStyle = FontStyles.Italic;
        }

        private void curisva_CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            salida_TextBlock.FontStyle = FontStyles.Normal;
        }

        
    }
}
