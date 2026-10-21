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

namespace MedCentr.ViewWindow.Windows
{
    /// <summary>
    /// Логика взаимодействия для DoctorAdminWindow.xaml
    /// </summary>
    public partial class DoctorAdminWindow : Window
    {
        public DoctorAdminWindow()
        {
            InitializeComponent();
        }

        private void MyDoctorRecordButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewWindow.Pages.MyDoctorRecordPage());
            PageTitleText.Text = "Мои записи";
        }

        private void DoctorScheduleButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewWindow.Pages.DoctorSchedulePage());
            PageTitleText.Text = "Расписание";
        }
    }
}
