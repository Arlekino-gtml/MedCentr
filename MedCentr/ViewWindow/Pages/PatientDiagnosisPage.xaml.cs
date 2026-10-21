using MedCentr.Model;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
    /// Логика взаимодействия для PatientDiagnosisPage.xaml
    /// </summary>
    public partial class PatientDiagnosisPage : Page
    {
        public PatientDiagnosisPage(Appointment appointment)
        {
            InitializeComponent();
            LoadPatientDiagnosis(appointment);
        }

        private void LoadPatientDiagnosis(Appointment appointment)
        {
            if (appointment == null)
            {
                LstPatientDiagnosis.ItemsSource = null;
                return;
            }

            int appointmentId = appointment.idAppointment;

            LstPatientDiagnosis.ItemsSource = App.context.ConsultationResult
                .Where(r => r.idAppointment == appointmentId)
                .ToList();
        }
        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
