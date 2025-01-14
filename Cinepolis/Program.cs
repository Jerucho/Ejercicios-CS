using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinepolis.Comandos;

namespace Cinepolis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListarPeliculas listarPeliculas = new ListarPeliculas();
            listarPeliculas.Ejecutar();
        }
    }
}
