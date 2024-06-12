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

    [Persistent(@"detalle_venta")]
    public partial class Detalle_venta : XPLiteObject
    {
        int fIddetalle_venta;
        [Key(true)]
        [Persistent(@"iddetalle_venta")]
        public int Iddetalle_venta
        {
            get { return fIddetalle_venta; }
            set { SetPropertyValue<int>(nameof(Iddetalle_venta), ref fIddetalle_venta, value); }
        }
        int fCantidad;
        [Persistent(@"cantidad")]
        public int Cantidad
        {
            get { return fCantidad; }
            set { SetPropertyValue<int>(nameof(Cantidad), ref fCantidad, value); }
        }
        float fSubtotal;
        [Persistent(@"subtotal")]
        public float Subtotal
        {
            get { return fSubtotal; }
            set { SetPropertyValue<float>(nameof(Subtotal), ref fSubtotal, value); }
        }
        Producto fProducto_Id;
        [Persistent(@"producto_Id")]
        [Association(@"detalle_ventaReferencesproducto")]
        public Producto Producto_Id
        {
            get { return fProducto_Id; }
            set { SetPropertyValue<Producto>(nameof(Producto_Id), ref fProducto_Id, value); }
        }
        Venta fVenta_idVenta;
        [Persistent(@"venta_idVenta")]
        [Association(@"detalle_ventaReferencesventa")]
        public Venta Venta_idVenta
        {
            get { return fVenta_idVenta; }
            set { SetPropertyValue<Venta>(nameof(Venta_idVenta), ref fVenta_idVenta, value); }
        }
    }

}
