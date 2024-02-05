using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using KR2_Alekseev;
using KR2_Alekseev.Model;

namespace KR2_Alekseev
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static KR2_AlekseevEntities1 DB = new KR2_AlekseevEntities1();
        public static Employee LoggedEmployee;
    }
}
