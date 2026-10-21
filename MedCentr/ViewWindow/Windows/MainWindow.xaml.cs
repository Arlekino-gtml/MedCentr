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

namespace MedCentr
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            var User =  App.context.User.FirstOrDefault( u => u.Login == Login.Text && u.Password == Password.Password);
            if(User != null)

            {   if (User.idRole == 2)
                { 
                MenuPacientWindow menuPacientWindow = new MenuPacientWindow();
                menuPacientWindow.Show();
                this.Close();
                }
                if (User.idRole == 1) 
                {
                  DoctorAdminWindow daw = new DoctorAdminWindow();
                  daw.Show();
                  this.Close();
                
                }

            }
            else
            {
                MessageBox.Show("Логин или пароль неверны ");
                Login.Clear();
                Password.Clear();
            }
        }
    }
}
