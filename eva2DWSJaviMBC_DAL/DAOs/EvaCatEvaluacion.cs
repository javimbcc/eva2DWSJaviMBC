using System;
using System.Collections.Generic;

namespace eva2DWSJaviMBC_DAL.Modelos;

public partial class EvaCatEvaluacion
{
    public string CodEvaluacion { get; set; } = null!;

    public string? DescEvaluacion { get; set; }

    public virtual ICollection<EvaTchNotasEvaluacion> EvaTchNotasEvaluacions { get; } = new List<EvaTchNotasEvaluacion>();
}
