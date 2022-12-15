using eva2DWSJaviMBC_DAL.Modelos;
using Npgsql;

namespace eva2DWSJaviMBC.Models.DTOs.AlumEvToReaderList
{
    public class AlumEvToReaderList
    {
        public static List<EvaTchNotasEvaluacion> ReaderToList(NpgsqlDataReader resultadoConsulta)
        {
            List<EvaTchNotasEvaluacion> EvaData = new List<EvaTchNotasEvaluacion>();
            while (resultadoConsulta.Read())
            {

                EvaData.Add(new EvaTchNotasEvaluacion(

                        resultadoConsulta[0].ToString(),
                        resultadoConsulta[1].ToString(),
                        resultadoConsulta[2].ToString(),
                        resultadoConsulta[3].ToString(),
                        resultadoConsulta[4].ToString(),
                        resultadoConsulta[5].ToString()
                    ));

            }
            return EvaData;
        }
    }
}
