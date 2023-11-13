using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MessageBox = System.Windows.Forms.MessageBox;

namespace HelpSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Control control = new System.Windows.Forms.Control();
            Help.ShowHelp(control,"HtmlHelpProject.chm");

        }

        private void Grid_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            //MessageBox.Show("jhjh");
            if (e.Key == Key.H || e.Key == Key.F1)
            {
                System.Windows.Forms.Control control = new System.Windows.Forms.Control();
                Help.ShowHelp(control, "HtmlHelpProject.chm");
            }
        }
    }
}
