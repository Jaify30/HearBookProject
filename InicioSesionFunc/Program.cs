using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InicioSesionFunc
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static bool Validacion(string email, string password)
        {



            if (email=="pepe")
            {
                MessageBox.Show("el mail es correcto");
                return true;
            }
            else
            {
                MessageBox.Show("Credenciales Incorrectas");
                return false;
            }
        }
    }
}
