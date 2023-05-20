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

namespace DopZadanie5
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
            double A1 = double.Parse(TbNumberA.Text);
            double B1 = double.Parse(TbNumberB.Text);
            double C1 = double.Parse(TbNumberC.Text);
            double A2 = double.Parse(TbNumberD.Text);
            double B2 = double.Parse(TbNumberE.Text);
            double C2 = double.Parse(TbNumberF.Text);
            double D = A1 * B2 - A2 * B1; 
            double x = (C1 * B2 - C2 * B1) / D; 
            double y = (A1 * C2 - A2 * C1) / D;
            TextBlockAnswer.Text = $"Ответ: X={x:F2} Y={y:F2}";
        }
    }
}
