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
    /// Логика взаимодействия для MyDoctorRecordPage.xaml
    /// </summary>
    public partial class MyDoctorRecordPage : Page
        //записи которые видит врач
    {
        public MyDoctorRecordPage()
        {
            InitializeComponent();
            LoadMyDoctorRecord();
        }
        private void LoadMyDoctorRecord() 
        {
            LstDoctorRecord.ItemsSource = App.context.Appointment.ToList();
        
        
        }
        //private void LoadMyDoctorRecord()
        //{
        //    //// Получаем ID текущего врача из контекста
        //    //int doctorId = App.context.idUser;

        //    //// Берём все записи, где врач — этот доктор
        //    //var records = App.context.Appointment
        //    //    .Where(a => a.idDoctorUser == doctorId)
        //    //    .OrderByDescending(a => a.AppointmentDate)
        //    //    .ThenBy(a => a.StartTime)
        //    //    .ToList();


        //private void LstDoctorRecord_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    var appointment = LstDoctorRecord.SelectedItem as MedCentr.Model.Appointment;
        //    if (appointment == null)
        //        return;
        //    NavigationService.Navigate(new PatientDiagnosisPage(appointment));
        //    LstDoctorRecord.SelectedItem = null;
        //}
        
    }
}
