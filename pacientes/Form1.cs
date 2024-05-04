using MySql.Data.MySqlClient;
using System.Drawing;
using vehiculo;

namespace pacientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDAtos();
        }

        public void cargarDAtos()
        {
            conexion conexionDB = new conexion();
            conexionDB.conectar();
            conexionDB.Con.Open();
            vista.Rows.Clear();

            string query = "select * from equipo;";
            MySqlCommand comandoDB = new MySqlCommand(query, conexionDB.Con);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = vista.Rows.Add();
                        vista.Rows[n].Cells[0].Value = reader.GetInt32(0);
                        vista.Rows[n].Cells[1].Value = reader.GetString(1);
                        vista.Rows[n].Cells[2].Value = reader.GetString(2);
                        vista.Rows[n].Cells[3].Value = reader.GetString(3);

                    }
                }
                else
                {
                    Console.WriteLine("No hay vehiculos");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        public int insertarEquipo(string numeroserie, string tipo, string nombre, string version)
        {
            conexion conexionDB = new conexion();
            conexionDB.conectar();
            int codigoRegistroInsertado = 0;
            string sqlEjecutar = "insert into equipo (numeroserie, tipo, nombre, " +
                          "fechacompra, version) " +
                          "VALUES (@numeroserie, @tipo, @nombre, " +
                          "@fechacompra, @version); SELECT LAST_INSERT_ID()";

            try
            {

                MySqlCommand comandoSQL = new MySqlCommand();
                comandoSQL.Connection = conexionDB.Con;
                comandoSQL.CommandText = sqlEjecutar;
                comandoSQL.Parameters.Add("@numeroserie", MySqlDbType.String).Value = numeroserie;
                comandoSQL.Parameters.Add("@tipo", MySqlDbType.String).Value = tipo;
                comandoSQL.Parameters.Add("@nombre", MySqlDbType.String).Value = nombre;
                comandoSQL.Parameters.Add("@version", MySqlDbType.String).Value = version;
                comandoSQL.Parameters.Add("@fechacompra", MySqlDbType.DateTime).Value = DateTime.Now;
                conexionDB.Con.Open();
                codigoRegistroInsertado = Convert.ToInt32(comandoSQL.ExecuteScalar());
                return codigoRegistroInsertado;
            }
            catch (MySqlException ex)
            {
                return 0;
            }
            finally
            {
                conexionDB.Con.Close();
            }
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (insertarEquipo(txtserie.Text, txttipo.Text, txtnonbre.Text, txtversion.Text) > 0)
            {
                MessageBox.Show("Registro insertado");
                this.cargarDAtos();
            }
            else
            {
                MessageBox.Show("Registro no insertado");
            }

        }
    }
}