using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vehiculo
{
    public class conexion
    {
        private MySqlConnection con;

        public MySqlConnection Con { get => con; set => con = value; }

        public void conectar()
        {
            con = new MySqlConnection();
            try
            {
                con.ConnectionString = "Server=localhost;Database=umg; Uid=root;Pwd=1234;";
                con.Open();
                Console.WriteLine("conectado");
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("No conectado");

            }
            finally
            {
                con.Close(); //Cierra la conexión a MySQL
            }


        }
    }
}
