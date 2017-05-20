using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CapaLogica
{
    public class Registro
    {
        private string primerNombre;
        private string segundoNombre;
        private string primerApellido;
        private string segundoApellido;
        private string tipoIdentificacion;
        private int identificacion;
        private DateTime fechaNacimiento;
        private string genero;
        private string hobbies;
        private string RH;
        private string EPS;
        private string estadoCivil;
        private string profesion;
        private string correo;
        private string direccion;
        private Int64 telefonoMovil;
        private Int64 telefonoFijo;
        private string usuario;
        private string clave;
    
        public Registro(string primerNombre, string segundoNombre, string primerApellido,
            string segundoApellido, string tipoIdentificacion, int identificacion, DateTime fechaNacimiento,
            string genero, string hobbies, string RH, string EPS, string estadoCivil, string profesion,
            string correo, string direccion, Int64 telefonoMovil, Int64 telefonoFijo, string usuario, string clave)
        {
            this.primerNombre = primerNombre;
            this.segundoNombre = segundoNombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.tipoIdentificacion = tipoIdentificacion;
            this.identificacion = identificacion;
            this.fechaNacimiento = fechaNacimiento;
            this.genero = genero;
            this.hobbies = hobbies;
            this.RH = RH;
            this.EPS = EPS;
            this.estadoCivil = estadoCivil;
            this.profesion = profesion;
            this.correo = correo;
            this.direccion = direccion;
            this.telefonoMovil = telefonoMovil;
            this.telefonoFijo = telefonoFijo;
            this.usuario = usuario;
            this.clave = clave;
        }
        public Registro(string primerNombre,string PrimerApellido)
        {
            this.primerNombre = primerNombre;
            this.primerApellido = PrimerApellido;
        }

        public void MostrarRegistro()//string usuario,string clave)
        {
            //if (loTraigo == 1)
            //    MessageBox.Show("usuario y clave validos");
            
             

            //else
            //{
               MessageBox.Show("usuario o contraseña invalidos");

            //}
               
            

            //MessageBox.Show("su Primer Nombre es: "+ primerNombre+ " "+ "y apellido es  "+ primerApellido );
        }


    }

 
}
