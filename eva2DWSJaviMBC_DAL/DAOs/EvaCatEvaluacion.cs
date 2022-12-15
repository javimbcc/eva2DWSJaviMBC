using System;
using System.Collections.Generic;

namespace eva2DWSJaviMBC_DAL.Modelos;

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } 

    public string? DescEvaluacion { get; set; }

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();

    public EvaCatEvaluacion(string codeva, string desceva)
    {
        CodEvaluacion = codeva;
        DescEvaluacion = desceva;
    }
}

