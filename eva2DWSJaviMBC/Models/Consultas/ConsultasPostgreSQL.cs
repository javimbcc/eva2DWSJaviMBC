using eva2DWSJaviMBC_DAL.Modelos;
using Npgsql;
using System.Xml.Linq;

namespace eva2DWSJaviMBC.Models.Consultas
{
    public class ConsultasPostgreSQL
    {
        //Metodo para recoger todas las evaluaciones
        public static List<EvaTchNotasEvaluacion> RecolectarTodasLasEvaluaciones(IConfiguration _config)
        {
            List<EvaTchNotasEvaluacion> listaDatos = new List<EvaTchNotasEvaluacion>();
            try
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones]: Entrando a la consulta de todas las evaluaciones");
                //Cogemos la cadena de conexión de nuestro Contexto
                using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
                //Abrimos la conexion
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones]: Habriendo la conexión");
                connection.Open();
                //Definimos y ejecutamos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones]: Ejecutamos la consulta");
                NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"sc_evaluacion\".\"eva_tch_notas_evaluacion\"", connection);
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();
                //Metemos los datos de la consulta en una lista para poder manejarlos
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones]: Terminada ejecución de la consulta");
                listaDatos = DTOs.AlumEvToReaderList.AlumEvToReaderList.ReaderToList(resultadoConsulta);
                //Cerramos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones]: Cerrando la conexión");
                connection.Close();
            } catch (Exception e)
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones] (ERROR): " + e);

            }

            //Devolvemos la lista con los datos que nos interesan
            return listaDatos;
        }

        //Metodo para recoger la primera evaluacion
        public static List<EvaTchNotasEvaluacion> RecolectarPrimeraEvaluacion(IConfiguration _config)
        {
            List<EvaTchNotasEvaluacion> listaDatos = new List<EvaTchNotasEvaluacion>();
            try
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion]: Entrando a la consulta de todas las evaluaciones");
                //Cogemos la cadena de conexión de nuestro Contexto
                using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
                //Abrimos la conexion
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion]: Habriendo la conexión");
                connection.Open();
                //Definimos y ejecutamos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion]: Ejecutamos la consulta");
                NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"sc_evaluacion\".\"eva_tch_notas_evaluacion\" WHERE cod_evaluacion = 'PR' ", connection);
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();
                //Metemos los datos de la consulta en una lista para poder manejarlos
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion]: Terminada ejecución de la consulta");
                listaDatos = DTOs.AlumEvToReaderList.AlumEvToReaderList.ReaderToList(resultadoConsulta);
                //Cerramos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion]: Cerrando la conexión");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarPrimeraEvaluacion] (ERROR): " + e);

            }

            //Devolvemos la lista con los datos que nos interesan
            return listaDatos;
        }

        //Metodo para recoger la segunda evaluacion
        public static List<EvaTchNotasEvaluacion> RecolectarSegundaEvaluacion(IConfiguration _config)
        {
            List<EvaTchNotasEvaluacion> listaDatos = new List<EvaTchNotasEvaluacion>();
            try
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion]: Entrando a la consulta de todas las evaluaciones");
                //Cogemos la cadena de conexión de nuestro Contexto
                using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
                //Abrimos la conexion
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion]: Habriendo la conexión");
                connection.Open();
                //Definimos y ejecutamos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion]: Ejecutamos la consulta");
                NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"sc_evaluacion\".\"eva_tch_notas_evaluacion\" WHERE cod_evaluacion = 'SG'", connection);
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();
                //Metemos los datos de la consulta en una lista para poder manejarlos
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion]: Terminada ejecución de la consulta");
                listaDatos = DTOs.AlumEvToReaderList.AlumEvToReaderList.ReaderToList(resultadoConsulta);
                //Cerramos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion]: Cerrando la conexión");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarSegundaEvaluacion] (ERROR): " + e);

            }

            //Devolvemos la lista con los datos que nos interesan
            return listaDatos;
        }

        //Metodo para recoger la tercera evaluacion
        public static List<EvaTchNotasEvaluacion> RecolectarTerceraEvaluacion(IConfiguration _config)
        {
            List<EvaTchNotasEvaluacion> listaDatos = new List<EvaTchNotasEvaluacion>();
            try
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion]: Entrando a la consulta de todas las evaluaciones");
                //Cogemos la cadena de conexión de nuestro Contexto
                using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
                //Abrimos la conexion
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion]: Habriendo la conexión");
                connection.Open();
                //Definimos y ejecutamos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion]: Ejecutamos la consulta");
                NpgsqlCommand consulta = new NpgsqlCommand($"SELECT * FROM \"sc_evaluacion\".\"eva_tch_notas_evaluacion\" WHERE cod_evaluacion = 'TC'", connection);
                NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();
                //Metemos los datos de la consulta en una lista para poder manejarlos
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion]: Terminada ejecución de la consulta");
                listaDatos = DTOs.AlumEvToReaderList.AlumEvToReaderList.ReaderToList(resultadoConsulta);
                //Cerramos la consulta
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion]: Cerrando la conexión");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.RecolectarTerceraEvaluacion] (ERROR): " + e);

            }

            //Devolvemos la lista con los datos que nos interesan
            return listaDatos;
        }

        //Metodo para añadir registros del alumno

        public static void AñadirRegistros(IConfiguration _config, string MdUuid, string codAlumno, string NotaEv, string CodEva)
        {
            Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.AñadirRegistros]: Entrando a la consulta de todas las evaluaciones");
            //Cogemos la cadena de conexión de nuestro Contexto
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            //Abrimos la conexion
            Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.AñadirRegistros]: Habriendo la conexión");
            connection.Open();
            //Definimos y ejecutamos la consulta
            Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.AñadirRegistros]: Ejecutamos la consulta");
            NpgsqlCommand consulta = new NpgsqlCommand($"INSERT INTO \"sc_evaluacion\".\"eva_tch_notas_evaluacion\" (md_uuid,cod_alumno,nota_evaluacion,cod_evaluacion) VALUES('{MdUuid}','{codAlumno}','´{NotaEv}','{CodEva}')", connection);
            NpgsqlDataReader resultadoConsulta = consulta.ExecuteReader();
            //Hacemos la validación para ver si la contraseña es adecuada
            Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.AñadirRegistros]: Terminada ejecución de la consulta");
            //Cerramos la conexión
            Console.WriteLine("[Modelos-Consultas-ConsultasPostgreSQL.AñadirRegistros]: Cerrando la conexión");
            connection.Close();
        }
    }
}
