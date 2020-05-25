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
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cesarini.Filippo._4H.Meteo
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
            Meteo[] tempo = new Meteo[10];
            double max = 0;
            string città;
            int conta = 0;



            public MainWindow()
            {
                InitializeComponent();
                for (int i = 0; i < tempo.Length; i++)
                {
                    tempo[i] = new Meteo();
                }
                tempo[0].Nome = "Riccione";
                tempo[1].Nome = "Rimini";
                tempo[2].Nome = "Milano";
                tempo[3].Nome = "San Marino";

                tempo[0].Max = 33;
                tempo[1].Max = 28;
                tempo[2].Max = 30;
                tempo[3].Max = 13;

                tempo[0].Min = 13;
                tempo[1].Min = 10;
                tempo[2].Min = 2;
                tempo[3].Min = 0;

                tempo[0].Escursione = 20;
                tempo[1].Escursione = 18;
                tempo[2].Escursione = 28;
                tempo[3].Escursione = 13;

                conta = 4;



                max = tempo[0].Escursione;

                for (int i = 0; i < tempo.Length; i++)
                {
                    if (tempo[i].Escursione > max)
                    {
                        max = tempo[i].Escursione;
                        città = tempo[i].Nome;
                    }

                }

                Citta.Text = $"{Convert.ToString(città)}  Escursione termica: {Convert.ToString(max)}";

                dgdati.ItemsSource = tempo;
           
            }



            private void Button_Click(object sender, RoutedEventArgs e)
            {
                Window1 nuova = new Window1();
                nuova.ShowDialog();


                StreamReader sw = new StreamReader("dati.txt");
                string r = sw.ReadLine();
                string[] dato = r.Split(';');
                tempo[conta].Nome = dato[0];
                tempo[conta].Max = Convert.ToDouble(dato[1]);
                tempo[conta].Min = Convert.ToDouble(dato[2]);
                double datoMax = Convert.ToDouble(dato[1]);
                double datoMin = Convert.ToDouble(dato[2]);
                tempo[conta].Escursione = datoMax - datoMin;
                sw.Close();

                conta = conta + 1;

                dgdati.Items.Refresh();
            }

            private void Button_Click_1(object sender, RoutedEventArgs e)
            {
                bool go = false;
                for (int i = 0; i < tempo.Length; i++)
                {
                    if (cerca.Text == tempo[i].Nome)
                    {
                        cerca.Text = tempo[i].Nome;
                        go = true;

                        Ricerca.Text = $"Città: {tempo[i].Nome}; Temp.Max: {tempo[i].Max}; Temp.Min: {tempo[i].Min}; Escursione termica: {tempo[i].Escursione}";

                    }
                }

                if (go == false)
                {
                    MessageBox.Show("ERRORE! La città cercata non è presente");
                    cerca.Text = "";
                }
            }

       
    }
    }

