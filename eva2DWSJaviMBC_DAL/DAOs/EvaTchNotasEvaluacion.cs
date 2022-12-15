using System;
using System.Collections.Generic;

namespace eva2DWSJaviMBC_DAL.Modelos;

/// <summary>
/// Entidad que almacena las notas de evaluación de los alumnos
/// </summary>
public partial class EvaTchNotasEvaluacion
{
    public string? MdUuid { get; set; }

    public string? MdFch { get; set; }

    public string IdNotaEvaluacion { get; set; }

    public string? CodAlumno { get; set; }

    public string? NotaEvaluacion { get; set; }

    public string? CodEvaluacion { get; set; }

    public virtual EvaCatEvaluacion? CodEvaluacionNavigation { get; set; }

    //Constructor

    public EvaTchNotasEvaluacion(string? mduuid, string mdfch, string id, string codalumno, string notaevaluacion, string codevaluacion)
    {
        MdUuid = mduuid;
        MdFch = mdfch;
        IdNotaEvaluacion = id;
        CodAlumno = codalumno;
        NotaEvaluacion = notaevaluacion;
        CodEvaluacion = codevaluacion;
    }
}
