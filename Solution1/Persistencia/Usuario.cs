﻿using System;
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

        //Los datos de la segunda tabla 
        public DataTable Mostar_tabla2()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();

            comando.Connection = conexion.Abrir_conexion();

            comando.CommandText = "select * from Experiencia";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrar_conexion();

            return tabla;
        }

        public void Insertar2(string N_empresa, string Cargo, string Area, string Jefe, int Telefono)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_InsertExperiencia";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@N_empresa", N_empresa);
                comando.Parameters.AddWithValue("@Cargo", Cargo);
                comando.Parameters.AddWithValue("@Area", Area);
                comando.Parameters.AddWithValue("@Jefe", Jefe);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Cambiar2(int Id_experiencia, string N_empresa, string Cargo, string Area, string Jefe, int Telefono)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_UpdateExperiencia";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_experiencia", Id_experiencia);
                comando.Parameters.AddWithValue("@N_empresa", N_empresa);
                comando.Parameters.AddWithValue("@Cargo", Cargo);
                comando.Parameters.AddWithValue("@Area", Area);
                comando.Parameters.AddWithValue("@Jefe", Jefe);
                comando.Parameters.AddWithValue("@Telefono", Telefono);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Eliminar2(int Id_experiencia)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();

                comando.CommandText = "SP_DeleteExperiencia";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id_experiencia", Id_experiencia);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        //lOS datos de la tercera tabla
        public DataTable Mostar_tabla3()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();

            comando.Connection = conexion.Abrir_conexion();
            comando.CommandText = "select * from Cursos";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrar_conexion();

            return tabla;
        }

        public void Insertar3(string Centro, string Estudio, string Nivel, string F_inicio, string Estado, string F_final)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP__InsertCursos";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Centro", Centro);
                comando.Parameters.AddWithValue("@Estudio", Estudio);
                comando.Parameters.AddWithValue("@Nivel", Nivel);
                comando.Parameters.AddWithValue("@F_inicio", F_inicio);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@F_final", F_final);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Cambiar3(int Id_cursos, string Centro, string Estudio, string Nivel, string F_inicio, string Estado, string F_final)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "sp__UpdateCursos";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_cursos", Id_cursos);
                comando.Parameters.AddWithValue("@Centro", Centro);
                comando.Parameters.AddWithValue("@Estudio", Estudio);
                comando.Parameters.AddWithValue("@Nivel", Nivel);
                comando.Parameters.AddWithValue("@F_inicio", F_inicio);
                comando.Parameters.AddWithValue("@Estado", Estado);
                comando.Parameters.AddWithValue("@F_final", F_final);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Eliminar3(int Id_cursos)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();

                comando.CommandText = "DELETE FROM Cursos WHERE Id_cursos = @Id_cursos";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Id_cursos", Id_cursos);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        //Los datos de la cuarta tabla
        public DataTable Mostar_tabla4()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();

            comando.Connection = conexion.Abrir_conexion();

            comando.CommandText = "select * from Medico";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrar_conexion();

            return tabla;
        }
        public void Insertar4(string E_cronica, string Cirugia, string Medicamentos, string Alergia, string Lesiones)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_InsertMedico";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@E_cronica", E_cronica);
                comando.Parameters.AddWithValue("@Cirugia", Cirugia);
                comando.Parameters.AddWithValue("@Medicamentos", Medicamentos);
                comando.Parameters.AddWithValue("@Alergia", Alergia);
                comando.Parameters.AddWithValue("@Lesiones", Lesiones);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Cambiar4(int Id_Medico, string E_cronica, string Cirugia, string Medicamentos, string Alergia, string Lesiones)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_UpdateMedico";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_Medico", Id_Medico);
                comando.Parameters.AddWithValue("@E_cronica", E_cronica);
                comando.Parameters.AddWithValue("@Cirugia", Cirugia);
                comando.Parameters.AddWithValue("@Medicamentos", Medicamentos);
                comando.Parameters.AddWithValue("@Alergia", Alergia);
                comando.Parameters.AddWithValue("@Lesiones", Lesiones);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Eliminar4(int Id_Medico)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();

                comando.CommandText = "DELETE FROM Medico WHERE Id_Medico = @Id_Medico";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@Id_Medico", Id_Medico);


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        //Datos de la quinta tabla 
        public DataTable Mostar_tabla5()
        {
            SqlDataReader leer;
            DataTable tabla = new DataTable();

            comando.Connection = conexion.Abrir_conexion();

            comando.CommandText = "select * from Conocimiento";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.Cerrar_conexion();

            return tabla;
        }

        public void Insertar5(string Puesto_E, decimal Salario, string Idioma, string Programas)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_InsertConocimiento";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Puesto_E", Puesto_E);
                comando.Parameters.AddWithValue("@Salario", Salario);
                comando.Parameters.AddWithValue("@Idioma", Idioma);
                comando.Parameters.AddWithValue("@Programas", Programas);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }
        public void Cambiar5(int Id_conocimiento, string Puesto_E, decimal Salario, string Idioma, string Programas)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "sp_UpdateConocimiento";
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@Id_conocimiento", Id_conocimiento);
                comando.Parameters.AddWithValue("@Puesto_E", Puesto_E);
                comando.Parameters.AddWithValue("@Salario", Salario);
                comando.Parameters.AddWithValue("@Idioma", Idioma);
                comando.Parameters.AddWithValue("@Programas", Programas);

                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }

        public void Eliminar5(int Id_conocimiento)
        {
            try
            {
                comando.Connection = conexion.Abrir_conexion();
                comando.CommandText = "SP_DeleteConocimiento";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@Id_conocimiento", Id_conocimiento);


                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                comando.Connection = conexion.Cerrar_conexion();
            }
        }
    }
}
