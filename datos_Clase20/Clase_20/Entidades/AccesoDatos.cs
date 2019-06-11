using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Entidades
{
    public class AccesoDatos
    {
        private SqlConnection _conexion;
        private SqlCommand _comando;

        public AccesoDatos()
        {
            this._conexion = new SqlConnection(Properties.Settings.Default.conexion_bd);
        }

        public List<Persona> TraerTodos()
        {
            List<Persona> personas = new List<Persona>();
            SqlDataReader dataReader;

            try
            {
                this._comando = new SqlCommand();
                this._comando.Connection = this._conexion;
                this._comando.CommandType = CommandType.Text;
                this._comando.CommandText = "SELECT id,nombre,apellido,edad FROM Padron.dbo.Personas";

                this._conexion.Open();

                dataReader = this._comando.ExecuteReader();

                while(dataReader.Read())
                {
                    Persona p = new Persona((int)dataReader["id"], dataReader["nombre"].ToString(), dataReader["apellido"].ToString(), (int)dataReader["edad"]);
                    personas.Add(p);
                }

                this._conexion.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return personas;
        }

        public bool AgregarPersona(Persona p)
        {
            bool retorno = false;
            try
            {
                this._comando = new SqlCommand();
                this._comando.Connection = this._conexion;
                this._comando.CommandType = CommandType.Text;
                this._comando.CommandText = "INSERT INTO Padron.dbo.Personas (nombre,apellido,edad) VALUES('"+p.nombre+"','"+p.apellido+"',"+p.edad.ToString()+")";

                this._conexion.Open();

                if(this._comando.ExecuteNonQuery() > 0)
                retorno = true;

                this._conexion.Close();

            }
            catch (Exception e)
            {

                //Console.WriteLine(e.Message);
            }

            return retorno;
        }
    }
}
