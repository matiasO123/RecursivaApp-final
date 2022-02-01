using AccesoDatos;
using System;
using System.Data;

namespace CapaPresentacion.Controller
{
    class SocioController
    {
        public int TotalSocios()
        {
            ConexionGeneral cg = new ConexionGeneral();
            return Convert.ToInt32(cg.ValorUnico("SELECT COUNT(nombre) FROM socios"));
        }

        public decimal PromEdadRacing()
        {
            ConexionGeneral cg = new ConexionGeneral();
            decimal decimalParcial = decimal.Parse(cg.ValorUnico("Select AVG(edad) FROM socios WHERE equipo = 'Racing'"));
            return Decimal.Parse(decimalParcial.ToString("0.00"));
        }

        public DataSet MenoresCasadosConUniversitario()
        {
            ConexionGeneral cg = new ConexionGeneral();
            return cg.Consultor("Select nombre, edad, equipo FROM socios WHERE nEstudio = 'Universitario' AND eCivil = 'Casado' Order by edad LIMIT 100");

        }

        public DataSet NombresComunesRiver()
        {
            ConexionGeneral cg = new ConexionGeneral();
            return cg.Consultor("Select nombre, COUNT (nombre) as 'Cantidad de tocayos' FROM  socios WHERE equipo = 'River' GROUP BY nombre ORDER BY COUNT (nombre) DESC LIMIT 5");
        }

        public DataSet EdadesXEquipo()
        {
            ConexionGeneral cg = new ConexionGeneral();
            return cg.Consultor("SELECT equipo, COUNT(nombre) as 'Cant. socios', MAX(edad) as 'Más viejo', MIN(edad) as 'más joven', AVG(edad) as 'Promedio' FROM socios GROUP BY equipo ORDER BY COUNT(nombre) DESC");
        }
    }
}
