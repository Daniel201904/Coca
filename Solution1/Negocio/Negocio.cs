using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace Negocio
{
    public class NegocioNG
    {
        private Usuario log = new Usuario();
        bool V = false;

        public bool Verificar(string correo, string contraseña)
        {
            V = log.VerificarUsuario(correo, contraseña);
            return V;
        }

        //tabla 1 

        Usuario persona = new Usuario();
        public void Digitar1(string Tipo_documento, int Numero_documento, string Nombres, string Apellidos, string Genero, string Fecha_nacimiento, string Direccion, string Correo, int Telefono, int Contraseña)
        {
            persona.Insertar1(Tipo_documento, Numero_documento, Nombres, Apellidos, Genero, Fecha_nacimiento, Direccion, Correo, Telefono, Contraseña);
        }

        //Tabla 2
        public DataTable Mostrar_Tabla2()
        {
            DataTable TB = new DataTable();
            TB = persona.Mostar_tabla2();
            return TB;
        }
        public void Digitar2(string N_empresa, string Cargo, string Area, string Jefe, int Telefono)
        {
            persona.Insertar2(N_empresa, Cargo, Area, Jefe, Telefono);
        }
        public void Diferente2(int Id_experiencia, string N_empresa, string Cargo, string Area, string Jefe, int Telefono)
        {
            persona.Cambiar2(Id_experiencia, N_empresa, Cargo, Area, Jefe, Telefono);
        }
        public void Borrar2(int Id_experiencia)
        {
            persona.Eliminar2(Id_experiencia);
        }

        //Tabla 3
        public DataTable Mostrar_Tabla3()
        {
            DataTable TB = new DataTable();
            TB = persona.Mostar_tabla3();
            return TB;
        }
        public void Digitar3(string Centro, string Estudio, string Nivel, string F_inicio, string Estado, string F_final)
        {
            persona.Insertar3(Centro, Estudio, Nivel, F_inicio, Estado, F_final);
        }
        public void Diferente3(int Id_cursos, string Centro, string Estudio, string Nivel, string F_inicio, string Estado, string F_final)
        {
            persona.Cambiar3(Id_cursos, Centro, Estudio, Nivel, F_inicio, Estado, F_final);
        }
        public void Borrar3(int Id_cursos)
        {
            persona.Eliminar3(Id_cursos);
        }

        //Tabla 4
        public DataTable Mostrar_Tabla4()
        {
            DataTable TB = new DataTable();
            TB = persona.Mostar_tabla4();
            return TB;
        }
        public void Digitar4(string E_cronica, string Cirugia, string Medicamentos, string Alergia, string Lesiones)
        {
            persona.Insertar4(E_cronica, Cirugia, Medicamentos, Alergia, Lesiones);
        }
        public void Diferente4(int Id_Medico, string E_cronica, string Cirugia, string Medicamentos, string Alergia, string Lesiones)
        {
            persona.Cambiar4(Id_Medico, E_cronica, Cirugia, Medicamentos, Alergia, Lesiones);
        }
        public void Borrar4(int Id_Medico)
        {
            persona.Eliminar4(Id_Medico);
        }

        //Tabla 5
        public DataTable Mostrar_Tabla5()
        {
            DataTable TB = new DataTable();
            TB = persona.Mostar_tabla5();
            return TB;
        }
        public void Digitar5(string Puesto_E, decimal Salario, string Idioma, string Programas)
        {
            persona.Insertar5(Puesto_E, Salario, Idioma, Programas);
        }
        public void Diferente5(int Id_conocimiento, string Puesto_E, decimal Salario, string Idioma, string Programas)
        {
            persona.Cambiar5(Id_conocimiento, Puesto_E, Salario, Idioma, Programas);
        }
        public void Borrar5(int Id_conocimiento)
        {
            persona.Eliminar5(Id_conocimiento);
        }
    }
}
