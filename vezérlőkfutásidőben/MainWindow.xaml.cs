using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace vezérlőkfutásidőben
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            grElements.Children.Add(new Button() { Content = $"Gomb{grElements.Children.Count}" });
        }

        private void paint_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < grElements.Children.Count; i++)
            {
                if (i%int.Parse(tbxHanyadik.Text)==0)
                {
                    (grElements.Children[i] as Button).Background = Brushes.Black;
                }
            }
        }
        private void map_Click(object sender, RoutedEventArgs e)
        {
            int sor = 3;
            int oszlop = 3;
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    map.Children.Add
                }
            }
        }
    }
}