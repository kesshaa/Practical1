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
using static System.Math;
namespace Zadanie2
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

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            double S = double.Parse(TbNumberA.Text);
            double pi = 3.14;
            double D = Sqrt(S * 4.0 / pi);
            double L = pi * D;
            TextBlockAnswer.Text = ($"Диаметр круга равен {D:f2} , Длина окружности круга равна {L:f2}" );
        }
    }
}
