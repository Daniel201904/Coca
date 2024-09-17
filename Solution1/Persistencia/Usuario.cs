using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class Usuario
    {
        SqlDataReader reader;
        Conexion conexion = new Conexion();
        SqlCommand comando = new SqlCommand();
        bool V;
        public bool VerificarUsuario(string correo, string contraseña)
        {
            comando.CommandText = "select * from Datos_personales";
            comando.Connection = conexion.Abrir_conexion();
            comando.CommandType = System.Data.CommandType.Text;
            reader = comando.ExecuteReader();
            comando.Parameters.Clear();

            while (reader.Read())
            {
                if (reader[8].ToString() == correo && reader[10].ToString() == contraseña)
                {
                    V = true; break;
                }
            }

            conexion.Cerrar_conexion();

            return V;
        }
        public void Insertar1(string Tpo_documento, int Numero_documento, string Nombres, string Apellidos, string Genero, string Fecha_nacimiento, string Direccion, string Correo, int Telefono, int Contraseña)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_InsertDatosPersonales";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Tpo_documento", Tpo_documento);
                comando.Parameters.AddWithValue("@Numero_documento", Numero_documento);
                comando.Parameters.AddWithValue("@Nombres", Nombres);
                comando.Parameters.AddWithValue("@Apellidos", Apellidos);
                comando.Parameters.AddWithValue("@Genero", Genero);
                comando.Parameters.AddWithValue("@Fecha_nacimiento", Fecha_nacimiento);
                comando.Parameters.AddWithValue("@Direccion", Direccion);
                comando.Parameters.AddWithValue("@Correo", Correo);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.Parameters.AddWithValue("@Contraseña", Contraseña);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conexion.Cerrar_conexion();
            }
        }
    }
}
