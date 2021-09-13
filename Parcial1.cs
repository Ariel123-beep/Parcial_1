using Parcial_1.Entidades;
using Parcial_1.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsUsuario usuario = new ClsUsuario();
            NclsUsuario nclsusuario = new NclsUsuario();

            Console.WriteLine("Ingresa tu nombre");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingresa tu contraseña");
            usuario.Contraseña = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(nclsusuario.ACCESO(usuario));
            Console.ReadLine();

        }
    }
}
