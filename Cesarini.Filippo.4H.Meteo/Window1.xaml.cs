using System;
using System.Collections.Generic;
using System.IO;
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

namespace Cesarini.Filippo._4H.Meteo
{
    /// <summary>
    /// Logica di interazione per Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
         
        public bool esc;
        public Window1()
        {
            InitializeComponent();
        }

        private void annulla_Click(object sender, RoutedEventArgs e)
        {
            esc = false;
            this.Close();
        }

        private void salva_Click(object sender, RoutedEventArgs e)
        {

            StreamWriter sw = new StreamWriter("dati.txt");
            sw.Write($"{nomecitta.Text};");
            sw.Write($"{Tmax.Text};");
            sw.Write($"{Tmin.Text};");
            sw.Close();

            esc = true;
            this.Close();

        }
    }
}
