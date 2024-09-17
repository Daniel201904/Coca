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
    }
}
