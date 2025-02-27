using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        public static SqlConnection Conexionbbdd()
        {
            SqlConnection conexionbbdd = new SqlConnection(@"Server=(localdb)\MSSQLLocalDB; Database=HearBookDB; Trusted_Connection=True; Integrated Security=True;");

            conexionbbdd.Open();

            return conexionbbdd;
        }
    }
}
