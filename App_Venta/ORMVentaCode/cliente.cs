using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace App_Venta.venta
{

    public partial class Cliente
    {
        public Cliente(Session session) : base(session) { }// Permite la comunicacion a la base de datos
        public override void AfterConstruction() { base.AfterConstruction(); }

        public string Nombre_Completo
        {
            get { return (Nombre + " " + Apellido); }
        }

    }

}
