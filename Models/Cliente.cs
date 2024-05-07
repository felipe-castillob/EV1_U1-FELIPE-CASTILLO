using System;
using System.Collections.Generic;

namespace EV1_U1_Felipe_Castillo.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string RutCliente { get; set; } = null!;

    public string NombreCliente { get; set; } = null!;

    public string ApellidoPaternoCliente { get; set; } = null!;

    public string ApellidoMaternoCliente { get; set; } = null!;

    public string CorreoCliente { get; set; } = null!;

    public string DireccionCliente { get; set; } = null!;

    public string TelefonoCliente { get; set; } = null!;

    public DateTime FechaInscripcionCliente { get; set; }
}
