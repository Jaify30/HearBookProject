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

namespace InicioSesion
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Minimizar_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Cerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            string emailIngresado = email.Text;
            string passIngresada = password.Password;

            if(InicioSesionFunc.Program.Validacion(emailIngresado, passIngresada))
            {
                
            }
        }

        private void Olvidar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Registro_Click(object sender, RoutedEventArgs e)
        {
            Registro.MainWindow VentanaRegistro = new Registro.MainWindow();
            VentanaRegistro.ShowDialog();


        }
    }
}
