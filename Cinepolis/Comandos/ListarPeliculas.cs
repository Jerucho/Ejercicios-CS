using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cinepolis.Datos;
using Cinepolis.Models;

namespace Cinepolis.Comandos
{
    internal class ListarPeliculas : IComando
    {
        ServicioPeliculas servicioPeliculas = new ServicioPeliculas();


        public void Ejecutar()
        {
            Console.WriteLine("Listado de Peliculas");
            List<Pelicula> peliculas = servicioPeliculas.getPeliculas();
            for (int index = 0; index < peliculas.Count; index++)
            {
                Console.WriteLine($"{index + 1}. {peliculas[index].Titulo}");
            }

            Console.WriteLine("Seleccione una pelicula");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Seleccionaste la pelicula {peliculas[opcion - 1].Titulo}");
        }
    }
}
