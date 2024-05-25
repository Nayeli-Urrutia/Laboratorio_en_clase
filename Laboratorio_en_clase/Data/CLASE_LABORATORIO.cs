using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_en_clase.Data
{
    internal class CLASE_LABORATORIO


    {


        // Información de conexión a la base de datos
        private String connectionString = "Server=localhost;Database= db_universidad; Uid=root;Pwd=Dios1234";

        //constructor
        public CLASE_LABORATORIO(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=db_universidad;Uid=" + usur + ";Pwd=" + pwd + "Dios1234";
        }

        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Método para leer todos los objetos
        public DataTable LeerObjetos()
        {
            DataTable objetos = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM catalogo_consolas";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(objetos);
                    }
                }
            }

            return objetos;
        }

        // Método parametro el objeto
        public int objetomodel(int Id , string Nombre_Consola, string Compania, DateTime Anio_lanzamiento, string Generacion)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO catalogo_consolas ( Id, Nombre_Consola, Compania, Anio_lanzamiento, Generacion) VALUES (@Id, @Nombre_Consola, @Compania, @Anio_lanzamiento, @Generacion)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("@Nombre_Consola", Nombre_Consola);
                    command.Parameters.AddWithValue("@Compania", Compania);
                    command.Parameters.AddWithValue("@Anio_lanzamiento", Anio_lanzamiento);
                    command.Parameters.AddWithValue("@Generacion", Generacion);

                    
                    return command.ExecuteNonQuery();

                }
         


            }
        }

       
    }
}
