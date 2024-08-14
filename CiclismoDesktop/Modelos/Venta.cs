using System;
using System.Collections.Generic;

namespace CiclismoDesktop.Modelos;

public partial class Venta
{
    public int IdVenta { get; set; }

    public decimal? VentaTotal { get; set; }

    public int? IdCliente { get; set; }

    public int? IdEmpleado { get; set; }

    public DateTime? FechaPedido { get; set; }

    public DateTime FechaAtencionSolicitada { get; set; }

    public DateTime? FechaDespacho { get; set; }

    public string? EmpresaEnvio { get; set; }

    public bool Enviado { get; set; }

    public string? CasillaPostal { get; set; }

    public bool PagoRecibido { get; set; }

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual Empleado? IdEmpleadoNavigation { get; set; }
}
