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
    /// Логика взаимодействия для CapcthaWindow.xaml
    /// </summary>
    public partial class CapcthaWindow : Window

    {
        List<Image> images = new List<Image>()

        {
         new Image(){Source = new BitmapImage (new Uri ("C:\\Users\\Алёна\\source\\repos\\MedCentr\\MedCentr\\Images\\student.jpg")) , Tag = 1,Width= 300 },
         new Image(){Source = new BitmapImage (new Uri ("C:\\Users\\Алёна\\source\\repos\\MedCentr\\MedCentr\\Images\\student2.jpg")) , Tag = 2,Width= 300 },
         new Image(){Source = new BitmapImage (new Uri ("C:\\Users\\Алёна\\source\\repos\\MedCentr\\MedCentr\\Images\\student37.jpg")) , Tag = 3,Width= 300 },
         new Image(){Source = new BitmapImage (new Uri ("C:\\Users\\Алёна\\source\\repos\\MedCentr\\MedCentr\\Images\\student4.jpg")) , Tag = 4,Width= 300 }

        };

        public CapcthaWindow()
        {
            InitializeComponent();
        }

        private void MainLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void SelendaryLB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
