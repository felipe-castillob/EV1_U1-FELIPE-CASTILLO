using System;
using System.Collections.Generic;

namespace EV1_U1_Felipe_Castillo.Models;

public partial class Servicio
{
    public int IdServicio { get; set; }

    public string RutCliente { get; set; } = null!;

    public string DescServicio { get; set; } = null!;

    public int PrecioServicio { get; set; }

    public DateTime FechaInicioServicio { get; set; }

    public DateTime FechaTerminoServicio { get; set; }
}
