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

    [Persistent(@"categoria_usuario")]
    public partial class Categoria_usuario : XPLiteObject
    {
        int fIdcategoria_usuario;
        [Key(true)]
        [Persistent(@"idcategoria_usuario")]
        public int Idcategoria_usuario
        {
            get { return fIdcategoria_usuario; }
            set { SetPropertyValue<int>(nameof(Idcategoria_usuario), ref fIdcategoria_usuario, value); }
        }
        string fCategoria;
        [Size(45)]
        [Persistent(@"categoria")]
        public string Categoria
        {
            get { return fCategoria; }
            set { SetPropertyValue<string>(nameof(Categoria), ref fCategoria, value); }
        }
        [Association(@"UsuarioReferencesCategoria_usuario")]
        public XPCollection<Usuario> Usuarios { get { return GetCollection<Usuario>(nameof(Usuarios)); } }
    }

}
