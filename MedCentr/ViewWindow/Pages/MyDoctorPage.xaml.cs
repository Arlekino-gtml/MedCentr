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

namespace MedCentr.ViewWindow.Pages
{
    /// <summary>
    /// Логика взаимодействия для MyDoctorPage.xaml
    /// </summary>
    public partial class MyDoctorPage : Page
    {
        public MyDoctorPage()
        {
            InitializeComponent();
            LoadMyDoctor();
        }
        private void LoadMyDoctor()
        {
            LstMyDoctor.ItemsSource = App.context.User
                .Where(u => u.idRole == 1)
                .ToList();
        }
    }
}
