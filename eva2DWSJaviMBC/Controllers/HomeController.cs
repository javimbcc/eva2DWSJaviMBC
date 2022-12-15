using eva2DWSJaviMBC.Models;
using eva2DWSJaviMBC.Models.Consultas;
using eva2DWSJaviMBC_DAL.Modelos;
using Microsoft.AspNetCore.Mvc;
using Npgsql;
using System.Diagnostics;

namespace eva2DWSJaviMBC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        //añadimos nuestro archivo de configuracion json para recoger la cadena de conexion
        private readonly IConfiguration _config;


        public HomeController(ILogger<HomeController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        public IActionResult Index()
        {
            return View();
        }

        //Vista para buscar por evaluaciones
        public IActionResult BusquedaEv()
        {
            return View("BusquedaEv");
        }


        //Vista con todas las evaluaciones

        public IActionResult TodasLasEvaluaciones()
        {
            //Hacemos la conexion
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            //Declaramos la lista
            List<EvaTchNotasEvaluacion> dataUser = new List<EvaTchNotasEvaluacion>();
            //Hacemos la consulta y metemos sus datos en la lista
            dataUser = ConsultasPostgreSQL.RecolectarTodasLasEvaluaciones(_config);
            //Devolvemos los datos a la vista
            return View("TodasLasEvaluaciones",dataUser);
        }

        //Vista con la primera evaluacion

        public IActionResult PrimeraEv()
        {
            //Hacemos la conexion
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            //Declaramos la lista
            List<EvaTchNotasEvaluacion> dataUser = new List<EvaTchNotasEvaluacion>();
            //Hacemos la consulta y metemos sus datos en la lista
            dataUser = ConsultasPostgreSQL.RecolectarPrimeraEvaluacion(_config);
            //Devolvemos los datos a la vista
            return View("PrimeraEvaluacion",dataUser);
        }

        //Vista con la segunda evaluacion

        public IActionResult SegundaEv()
        {
            //Hacemos la conexion
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            //Declaramos la lista
            List<EvaTchNotasEvaluacion> dataUser = new List<EvaTchNotasEvaluacion>();
            //Hacemos la consulta y metemos sus datos en la lista
            dataUser = ConsultasPostgreSQL.RecolectarSegundaEvaluacion(_config);
            //Devolvemos los datos a la vista
            return View("SegundaEvaluacion",dataUser);
        }

        //Vista con la tercera evaluacion

        public IActionResult TerceraEvaluacion()
        {
            //Hacemos la conexion
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            //Declaramos la lista
            List<EvaTchNotasEvaluacion> dataUser = new List<EvaTchNotasEvaluacion>();
            //Hacemos la consulta y metemos sus datos en la lista
            dataUser = ConsultasPostgreSQL.RecolectarTerceraEvaluacion(_config);
            //Devolvemos los datos a la vista
            return View("TerceraEvaluacion",dataUser);
        }

        //Vista de añadir notas de evaluacion

        public IActionResult AñadirEv()
        {
            return View("AñadirEv");
        }
        [HttpPost]
        public IActionResult AñadirEv(string MdUuid, string Fecha, string codAlumno, string NotaEv, string CodEva)
        {
            //Hacemos la conexion
            using var connection = new NpgsqlConnection(_config.GetConnectionString("cadena"));
            Console.WriteLine("HABRIENDO CONEXION");
            connection.Open();
            //Ejecutamos el Insert
            ConsultasPostgreSQL.AñadirRegistros(_config, MdUuid, Fecha, codAlumno, NotaEv, CodEva);
            //Cerramos la conexion
            connection.Close();
            //Devolvemos a la vista inicial por si quiere seguir metiendo datos
            return View("AñadirEv");
        }


    }
}