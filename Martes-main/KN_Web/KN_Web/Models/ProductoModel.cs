using KN_Web.BaseDatos;
using KN_Web.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace KN_Web.Models
{
    public class ProductoModel
    {

        public List<tProducto> ConsultarProductos()
        {
            using (var context = new MARTES_BDEntities())
            {
                return context.tProducto.Include("tCategoria").ToList();
                //return context.ConsultarProductos().ToList();
            }
        }

        public tProducto ConsultarProductoConsecutivo(int Consecutivo)
        {
            using (var context = new MARTES_BDEntities())
            {
                return context.tProducto.Where(x => x.IdProducto == Consecutivo).FirstOrDefault();
            }
        }

        public List<tCategoria> ConsultarCategorias()
        {
            using (var context = new MARTES_BDEntities())
            {
                return context.tCategoria.ToList();
            }
        }

        public int RegistrarProducto(tProducto prd)
        {
            using (var context = new MARTES_BDEntities())
            {
                var consecutivo = context.RegistrarProducto(prd.Descripcion,prd.Inventario,prd.Precio,prd.Imagen,prd.IdCategoria).FirstOrDefault();
                return int.Parse(consecutivo.ToString());
            }
        }

        public bool ActualizarImagenProducto(tProducto prd)
        {
            var rowsAffected = 0;

            using (var context = new MARTES_BDEntities())
            {
                rowsAffected = context.ActualizarImagenProducto(prd.IdProducto, prd.Imagen);
            }

            return (rowsAffected > 0 ? true : false);
        }

        public bool ActualizarProducto(tProducto prd)
        {
            var rowsAffected = 0;

            using (var context = new MARTES_BDEntities())
            {
                rowsAffected = context.ActualizarProducto(prd.Descripcion,prd.Inventario,prd.Precio,prd.Imagen,prd.IdCategoria,prd.IdProducto);
            }

            return (rowsAffected > 0 ? true : false);
        }

    }
}