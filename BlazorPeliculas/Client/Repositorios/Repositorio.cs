using BlazorPeliculas.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPeliculas.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
{
            new Pelicula(){Titulo= "Spider man" , Lanzamiento = new DateTime(2019,7,2)},
            new Pelicula(){Titulo= "Star Wars" , Lanzamiento = new DateTime(2020,12,15)},
            new Pelicula(){Titulo= "Incepcion" , Lanzamiento = new DateTime(2021,4,26)}
        };
        }
    }
}
