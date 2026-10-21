using MedCentr.ViewWindow.Pages;
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
    /// Логика взаимодействия для MenuPacientWindow.xaml
    /// </summary>
    public partial class MenuPacientWindow : Window
    {
        public MenuPacientWindow()
        {
            InitializeComponent();
        }


        private void MyRecordButton_Click(object sender, RoutedEventArgs e)  /*переход на страницу мои записи */
        {
            MainFrame.Navigate(new ViewWindow.Pages.MyRecordPage());
            PageTitleText.Text = "Мои записи";
        }


        private void MainFrameSigUp_Navigated(object sender, RoutedEventArgs e)
        {
            //переход на окно записи на прием 
            SignUpPacientWindow spw = new SignUpPacientWindow();
            spw.ShowDialog();
           
        }
         //переход на страницу результаты
        private void ResultButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewWindow.Pages.ResultPage());
            PageTitleText.Text = "Результаты";

        }
        /*переход на страницу наши врачи */
        private void MyDoctorButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new ViewWindow.Pages.MyDoctorPage());
            PageTitleText.Text = "Наши врачи";
        }
    }
}
