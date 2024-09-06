﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KN_Web.BaseDatos
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MARTES_BDEntities : DbContext
    {
        public MARTES_BDEntities()
            : base("name=MARTES_BDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCarrito> tCarrito { get; set; }
        public virtual DbSet<tCategoria> tCategoria { get; set; }
        public virtual DbSet<tDetalle> tDetalle { get; set; }
        public virtual DbSet<tMaestro> tMaestro { get; set; }
        public virtual DbSet<tProducto> tProducto { get; set; }
        public virtual DbSet<tRol> tRol { get; set; }
        public virtual DbSet<tUsuario> tUsuario { get; set; }
    
        public virtual int ActualizarProducto(string descripcion, Nullable<int> inventario, Nullable<decimal> precio, string imagen, Nullable<int> idCategoria, Nullable<int> idProducto)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var inventarioParameter = inventario.HasValue ?
                new ObjectParameter("Inventario", inventario) :
                new ObjectParameter("Inventario", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("IdCategoria", idCategoria) :
                new ObjectParameter("IdCategoria", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarProducto", descripcionParameter, inventarioParameter, precioParameter, imagenParameter, idCategoriaParameter, idProductoParameter);
        }
    
        public virtual int ActualizarUsuario(string identificacion, string nombre, string correo, Nullable<byte> idRol, Nullable<int> consecutivo)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var idRolParameter = idRol.HasValue ?
                new ObjectParameter("IdRol", idRol) :
                new ObjectParameter("IdRol", typeof(byte));
    
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarUsuario", identificacionParameter, nombreParameter, correoParameter, idRolParameter, consecutivoParameter);
        }
    
        public virtual int CambiarEstadoUsuario(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CambiarEstadoUsuario", consecutivoParameter);
        }
    
        public virtual ObjectResult<ConsultarCarrito_Result> ConsultarCarrito(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarCarrito_Result>("ConsultarCarrito", consecutivoParameter);
        }
    
        public virtual ObjectResult<ConsultarDetalleFactura_Result> ConsultarDetalleFactura(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarDetalleFactura_Result>("ConsultarDetalleFactura", consecutivoParameter);
        }
    
        public virtual ObjectResult<ConsultarFacturas_Result> ConsultarFacturas(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarFacturas_Result>("ConsultarFacturas", consecutivoParameter);
        }
    
        public virtual ObjectResult<ConsultarProductos_Result> ConsultarProductos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarProductos_Result>("ConsultarProductos");
        }
    
        public virtual ObjectResult<ConsultarVentasMensuales_Result> ConsultarVentasMensuales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ConsultarVentasMensuales_Result>("ConsultarVentasMensuales");
        }
    
        public virtual int EliminarProductoCarrito(Nullable<int> consecutivo, Nullable<int> idProducto)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EliminarProductoCarrito", consecutivoParameter, idProductoParameter);
        }
    
        public virtual ObjectResult<IniciarSesion_Result> IniciarSesion(string correo, string contrasenna)
        {
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IniciarSesion_Result>("IniciarSesion", correoParameter, contrasennaParameter);
        }
    
        public virtual int PagarCarrito(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("PagarCarrito", consecutivoParameter);
        }
    
        public virtual int RegistrarCarrito(Nullable<int> consecutivo, Nullable<int> idProducto, Nullable<int> cantidad)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarCarrito", consecutivoParameter, idProductoParameter, cantidadParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> RegistrarProducto(string descripcion, Nullable<int> inventario, Nullable<decimal> precio, string imagen, Nullable<int> idCategoria)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var inventarioParameter = inventario.HasValue ?
                new ObjectParameter("Inventario", inventario) :
                new ObjectParameter("Inventario", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            var idCategoriaParameter = idCategoria.HasValue ?
                new ObjectParameter("IdCategoria", idCategoria) :
                new ObjectParameter("IdCategoria", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("RegistrarProducto", descripcionParameter, inventarioParameter, precioParameter, imagenParameter, idCategoriaParameter);
        }
    
        public virtual int RegistrarUsuario(string identificacion, string nombre, string correo, string contrasenna)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            var contrasennaParameter = contrasenna != null ?
                new ObjectParameter("Contrasenna", contrasenna) :
                new ObjectParameter("Contrasenna", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("RegistrarUsuario", identificacionParameter, nombreParameter, correoParameter, contrasennaParameter);
        }
    
        public virtual ObjectResult<ValidarExistencias_Result> ValidarExistencias(Nullable<int> consecutivo)
        {
            var consecutivoParameter = consecutivo.HasValue ?
                new ObjectParameter("Consecutivo", consecutivo) :
                new ObjectParameter("Consecutivo", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidarExistencias_Result>("ValidarExistencias", consecutivoParameter);
        }
    
        public virtual ObjectResult<ValidarUsuarioIdentificacion_Result> ValidarUsuarioIdentificacion(string identificacion)
        {
            var identificacionParameter = identificacion != null ?
                new ObjectParameter("Identificacion", identificacion) :
                new ObjectParameter("Identificacion", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ValidarUsuarioIdentificacion_Result>("ValidarUsuarioIdentificacion", identificacionParameter);
        }
    
        public virtual int ActualizarImagenProducto(Nullable<int> idProducto, string imagen)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("IdProducto", idProducto) :
                new ObjectParameter("IdProducto", typeof(int));
    
            var imagenParameter = imagen != null ?
                new ObjectParameter("Imagen", imagen) :
                new ObjectParameter("Imagen", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ActualizarImagenProducto", idProductoParameter, imagenParameter);
        }
    }
}
