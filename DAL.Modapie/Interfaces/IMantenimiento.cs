﻿using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Modapie
{
    public interface IMantenimiento
    {
        Usuario obtenerUsuarioUser(string username);

        int validarLogin(string username, string contrasena);


        /*ClienteAlxMayor*/
        void InsertarCAlxMayor(ClientePorMayor CAXM);
        void InsertarClienteAlxMayor(ClientePorMayor clientealxMayor);
        List<ClientePorMayor> MostarCAXM();
        void Editar(ClientePorMayor CAXM);
        void Borrar(ClientePorMayor CAXM);
        ClientePorMayor buscarClienteAlxMayor(string nombre);

        /*Gestion Empleado*/

        void InsertarEmpleado(Empleado empleado);

        List<Empleado> MostrarEmpleado();

        Empleado buscarEmpleado(string dni);

        void ActualizarEmpleado(Empleado empleado);

        /*Gestion de Productos al x MAYOR*/
        List<InventarioAlxMayor> MostrarProductos();
        InventarioAlxMayor obtenerLote(int id);
        

        void EliminarProdXMayor(int id);



        /*Cliente al detalle*/
        void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle);
        List<ClienteAlDetalle> MostrarClienteXDetalle();
        ClienteAlDetalle buscarCAD(string dni);

        void EditarCAD(ClienteAlDetalle CAXD);


        /*Inventario al x mayor*/

        List<InventarioAlxMayor> obtenerListaInventarioAlxMayor();
        


        /*Venta al por mayor*/

        void InsertarVentaAlxMayor(VentaAlxMayor ventaAlxMayor);

        VentaAlxMayor buscarUltimaVenta();

        /*Venta al detalle*/
        void InsertarVentaDetalle(VentaAlDetalle ventaDetalle);
        VentaAlDetalle buscarUltimaVentaDetalle();


        /*Apartados*/
        void InsertarApartado(Apartados apartado);
        Apartados buscarUltimoApartados();

        /*Descripcion venta al por mayor*/

        void InsertarDescripcionApartado(DescripcionApartados descripcionApartado);

        /*Descripcion venta al por mayor*/

        void InsertarDescripcionVentaAlxMayor(DescripcionVentaAlxMayor descripcionVentaAlxMayor);

        /*Descripcion de venta al detalle*/

        void InsertarDescripcionVentaAlDetalle(DescripcionVentaXDetalle descripcionVentaDetalle);

        /*usuario*/
        void InsertarUsuario(Usuario user);
        List<Usuario> MostrarUsuario();
        Usuario BuscarUsuario(string idEmpleado);
        void ModificarUsuario(Usuario user);

        //string BuscarCorreo(string username);

        //void ModificarUsuarioContrasena(string user, string password);

        /*Producto detalle*/
        void InsertarProductoDetalle(ProductoDetalle productoDetalle);
        List<ProductoDetalle> MostrarproductoDetalle();
        ProductoDetalle buscarproductoDetalle(string codigo);
        void EditarproductoDetalle(ProductoDetalle productoDetalle);
        ProductoDetalle MostrarUnproductoDetalle(int idProducto);
        
    }
}
