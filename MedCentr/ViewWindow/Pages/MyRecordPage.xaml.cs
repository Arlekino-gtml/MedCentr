using MedCentr.Model;
using MedCentr.ViewWindow.Windows;
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
    /// Логика взаимодействия для MyRecordPage.xaml
    /// </summary>
    public partial class MyRecordPage : Page
    {
        public MyRecordPage()
        {
            InitializeComponent();
            LoadAppointment();
        }
        private void LoadAppointment()
        {
            LstAppointment.ItemsSource = App.context.Appointment.ToList();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e) /* Поиск записей по ФИО врача */
        {
            string search = SearchBox.Text.Trim();
            LstAppointment.ItemsSource = App.context.Appointment
                .Where(r => App.context.User.Any(a => a.idUser==r.idDoctorUser && a.FIO.Contains(search))) /* обращаемся к таблице User и если idUser = idDoctorUser то выводиться ФИО*/
                .ToList();

               
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Clear();
            LoadAppointment ();
        }
        /* Удаление выбранной записи */
        private void CanselButton_Click(object sender, RoutedEventArgs e)
        {
            var appoinment = LstAppointment.SelectedItem as Appointment;
            if(appoinment == null)
            {
                MessageBox.Show("Выберите запись которую хотите отменить");
                return;
            }
            if (MessageBox.Show("Удалить выбранную запись ?","Подтверждение",MessageBoxButton.YesNo ) != MessageBoxResult.Yes)
            {
                return;
            }
            App.context.Appointment.Remove(appoinment);
            App.context.SaveChanges();
            LoadAppointment() ;
           
        }

        private void BackMenuPacientButton_Click(object sender, RoutedEventArgs e) /*возращение на окно MenuPacientWindow */
        {
            MenuPacientWindow mpw = new MenuPacientWindow();
            mpw.Owner = Window.GetWindow(this);

            mpw.ShowDialog();
            //пример
            LoadAppointment();


        }
    }
}
