using MedCentr.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MedCentr.ViewWindow.Windows
{
    /// <summary>
    /// Логика взаимодействия для SignUpPacientWindow.xaml
    /// </summary>
    public partial class SignUpPacientWindow : Window
    {
        public SignUpPacientWindow()
        {
            InitializeComponent();
            
            // загрузка врачей, условие подходит, если роль врача имеет idRole = 1
            DoctorBox.ItemsSource = App.context.User
                .Where(u => u.idRole == 1)
                .ToList();

            DateBox.DisplayDateStart = DateTime.Today; /*не дает выбирать прошедшие даты */
            TimeBox.ItemsSource = new []
            {
             "09:00",
             "09:30",
             "10:00",
             "10:30",
             "11:00",
             "11:30",
             "12:00",               
             "12:30",               
             "13:00",               
             "13:30",               
            };
        }

        //добавляет запись в Мои записи
        private void AddSigUpButton_Click(object sender, RoutedEventArgs e) 

        {
            var doctor = DoctorBox.SelectedItem as User;
            if (string.IsNullOrEmpty(DoctorBox.Text))
            {
                MessageBox.Show("Выберите врача");
                return;
            }
            if (string.IsNullOrEmpty(DateBox.Text))
            {
                MessageBox.Show("Выберите дату");
                return;
            }
            if (string.IsNullOrEmpty(TimeBox.Text))
            {
                MessageBox.Show("Выберите  время");
                return;
            }
            Appointment newAppoinment = new Appointment();
            newAppoinment.idDoctorUser = doctor.idUser;
            newAppoinment.AppointmentDate = DateBox.SelectedDate;
            newAppoinment.StartTime = TimeSpan.Parse(TimeBox.Text);

            App.context.Appointment.Add(newAppoinment);
            App.context.SaveChanges();

            DialogResult = true;
            MessageBox.Show("Вы успешно записаны");
        }
    }
}
