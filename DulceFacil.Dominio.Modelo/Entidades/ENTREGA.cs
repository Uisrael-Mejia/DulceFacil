﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dulce.Facil.Infraestructura.AccesoDatos;

public partial class ENTREGA
{
    public int id_entrega { get; set; }

    public int id_ruta { get; set; }

    public int id_pedido { get; set; }

    public int? orden_entrega { get; set; }

    public string estado_entrega { get; set; }

    public virtual PEDIDO id_pedidoNavigation { get; set; }

    public virtual RUTA_ENTREGA id_rutaNavigation { get; set; }
}