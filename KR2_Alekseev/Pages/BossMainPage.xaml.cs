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

namespace KR2_Alekseev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BossMainPage.xaml
    /// </summary>
    public partial class BossMainPage : Page
    {
        public BossMainPage()
        {
            InitializeComponent();
        }

        private void BDistribution_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DistributionPage());
        }

        private void BHiring_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListEmployees_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
