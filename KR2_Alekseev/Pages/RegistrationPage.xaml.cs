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
using KR2_Alekseev.Model;



namespace KR2_Alekseev.Pages
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
       Employee contexntemployee;
        public RegistrationPage()
        {
            InitializeComponent();

            contexntemployee = new Employee();
            DataContext = contexntemployee;
        }

        private void BReg_Click(object sender, RoutedEventArgs e)
        {
            App.DB.Employee.Add(contexntemployee);
            App.DB.SaveChanges();
            NavigationService.GoBack();
        }

        private void BBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
