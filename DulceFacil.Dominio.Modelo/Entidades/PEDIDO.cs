﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Dulce.Facil.Infraestructura.AccesoDatos;

public partial class PEDIDO
{
    public int id_pedido { get; set; }

    public int id_cliente { get; set; }

    public DateOnly? fecha { get; set; }

    public string estado { get; set; }

    public virtual ICollection<DETALLE_PEDIDO> DETALLE_PEDIDOs { get; set; } = new List<DETALLE_PEDIDO>();

    public virtual ENTREGA ENTREGA { get; set; }

    public virtual CLIENTE id_clienteNavigation { get; set; }
}