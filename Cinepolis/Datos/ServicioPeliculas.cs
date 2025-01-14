using System;
using System.Collections.Generic;
using Cinepolis.Models;
using MySqlConnector;

namespace Cinepolis.Datos
{
    internal class ServicioPeliculas
    {
        private List<Pelicula> peliculaList;
        private Pelicula pelicula;



        public ServicioPeliculas()
        {
            this.peliculaList = new List<Pelicula>();
        }

        public List<Pelicula> getPeliculas()
        {
            try
            {
                using (MySqlConnection con = (MySqlConnection)BD.getConnection())
                {
                    string query = "SELECT * FROM pelicula";
                    MySqlCommand com = new MySqlCommand(query, con);

                    MySqlDataReader dr = com.ExecuteReader();
                    var peliculaList = new List<Pelicula>();

                    while (dr.Read())
                    {
                        var pelicula = new Pelicula
                        {
                            Id = dr.GetInt32(0),
                            Titulo = dr.GetString(1),
                            Duracion = dr.GetInt32(2)
                        };
                        peliculaList.Add(pelicula);
                    }

                    return peliculaList;
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return null;
            }
        }


    }
}
