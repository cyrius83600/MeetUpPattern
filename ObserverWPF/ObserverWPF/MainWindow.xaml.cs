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

namespace ObserverWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Slider.ValueChanged += ObserverTextBox;
            Slider.ValueChanged += ObserverLabel;
            Slider.ValueChanged += ObserverTextBox;
        }

        private void ObserverTextBox(object sender, RoutedEventArgs e)
        {
            Texte.Text = "La valeur du slider a changé : " + Math.Ceiling(Slider.Value);
        }

        private void ObserverLabel(object sender, RoutedEventArgs e)
        {
            LabelRouge.Content = "La valeur du slider a changé : " + Math.Ceiling(Slider.Value);
        }
    }
}
