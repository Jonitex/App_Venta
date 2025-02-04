﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace App_Venta.venta
{

    [Persistent(@"venta")]
    public partial class Venta : XPLiteObject
    {
        int fIdVenta;
        [Key(true)]
        [Persistent(@"idVenta")]
        public int IdVenta
        {
            get { return fIdVenta; }
            set { SetPropertyValue<int>(nameof(IdVenta), ref fIdVenta, value); }
        }
        DateTime fFecha;
        public DateTime Fecha
        {
            get { return fFecha; }
            set { SetPropertyValue<DateTime>(nameof(Fecha), ref fFecha, value); }
        }
        string fDescuento;
        [Size(45)]
        public string Descuento
        {
            get { return fDescuento; }
            set { SetPropertyValue<string>(nameof(Descuento), ref fDescuento, value); }
        }
        int fCantidad;
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        float fMonto_total;
        public float Monto_total
        {
            get { return fMonto_total; }
            set { SetPropertyValue<float>(nameof(Monto_total), ref fMonto_total, value); }
        }
        Cliente fCliente_codigo;
        [Association(@"ventaReferencescliente")]
        public Cliente Cliente_codigo
        {
            get { return fCliente_codigo; }
            set { SetPropertyValue<Cliente>(nameof(Cliente_codigo), ref fCliente_codigo, value); }
        }
        bool fEstado;
        public bool Estado
        {
            get { return fEstado; }
            set { SetPropertyValue<bool>(nameof(Estado), ref fEstado, value); }
        }
        [Association(@"detalle_ventaReferencesventa")]
        public XPCollection<Detalle_venta> detalle_ventas { get { return GetCollection<Detalle_venta>(nameof(detalle_ventas)); } }
    }

}
