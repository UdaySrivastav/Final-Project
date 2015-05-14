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

namespace Calculator.CheckBook
{
    /// <summary>
    /// Interaction logic for CheckBookWindow.xaml
    /// </summary>
    public partial class CheckBookWindow : Window
    {
        CheckBookVM viewModel;

        public CheckBookWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel = new CheckBookVM();
            DataContext = viewModel;
            viewModel.Fill();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
