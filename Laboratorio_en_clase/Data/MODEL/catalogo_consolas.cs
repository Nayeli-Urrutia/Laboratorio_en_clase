using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_en_clase.Data.MODEL
{
    
        public class catalogo_consolas
    {
            public int id { get; set; }
            public string nombre_consola { get; set; }
            public string compania { get; set; }
            public DateTime anio_lanzamiento { get; set; }
            public string generacion { get; set; }
         

            // Constructor sin parámetros
            public catalogo_consolas() { }

        // Constructor con parámetros
        public catalogo_consolas(int Id, string Nombre_Consola, string Compania, DateTime Anio_lanzamiento, string Generacion)
            {
                id = Id;
                nombre_consola = Nombre_Consola;
                compania = Compania;
                anio_lanzamiento = Anio_lanzamiento;
                generacion = Generacion;
                
            }
        }
}
