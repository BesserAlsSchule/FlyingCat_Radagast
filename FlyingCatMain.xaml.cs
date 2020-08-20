using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace FlyingCat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private object sender;
        private RoutedEventArgs e;

        public MainWindow()
        {
            InitializeComponent();

            giphy_heaven.Play();

            giphy_heaven_MediaEnded_1(sender, e);
        }

        private void giphy_heaven_MediaEnded_1(object sender, RoutedEventArgs e)
        {
            giphy_heaven.Position = new TimeSpan(0, 0, 10);
            giphy_heaven.Play();
        }
    }
        
}
