using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS.Modapie
{
    public interface IMantenimiento
    {
        /*login*/
        Usuario obtenerUsuarioUser(string username);
        int validarLogin(string username, string contrasena);


        /*ClienteAlxMayor*/
        void InsertarCAlxMayor(ClientePorMayor CAXM);
        void InsertarClienteAlxMayor(ClientePorMayor clientealxMayor);
        List<ClientePorMayor> MostarCAXM();
        void Editar(ClientePorMayor CAXM);
        void Borrar(ClientePorMayor CAXM);
        ClientePorMayor buscarClienteAlxMayor(string nombre);


        /*Gestion de Empleado*/
        void InsertarEmpleado(Empleado empleado);
        List<Empleado> MostrarEmpleado();
        Empleado BuscarEmpleado(string dni);
        void ActualizarEmpleado(Empleado empleado);

        /*Gestion de productos al x Mayor*/
        List<InventarioAlxMayor> MostrarProductos();
        InventarioAlxMayor obtenerLote(int id);
        void EliminarProdXMayor(int id);


        /*Gestion del cliente al detalle*/
        void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle);
        List<ClienteAlDetalle> MostrarClienteXDetalle();
        ClienteAlDetalle buscarCAD(string dni);
        void EditarCAD(ClienteAlDetalle CAD);


        /*Inventario al x mayor*/
        List<InventarioAlxMayor> obtenerListaInventarioAlxMayor();

        /*Venta al por mayor*/
        void InsertarVentaAlxMayor(VentaAlxMayor ventaAlxMayor);
        VentaAlxMayor buscarUltimaVenta();

        /*Descripcion venta al por mayor*/
        void InsertarDescripcionVentaAlxMayor(DescripcionVentaAlxMayor descripcionVentaAlxMayor);

        /*Descripcion venta al detalle*/
        void InsertarDescripcionVentaAlDetalle(DescripcionVentaXDetalle descripcionVentaDetalle);

        /*Inventario detalle*/
        void ModificarCantidadProd(int id, int canti);

        /*Venta detalle*/
        void InsertarVentaDetalle(VentaAlDetalle ventaDetalle);
        VentaAlDetalle buscarUltimaVentaDetalle();

        /*usuario*/
        void iInsertarUsuario(Usuario usuario);
        List<Usuario> MostrarUsuario();
        Usuario BuscarUsuario(string idEmpleado);

        /*Producto detalle*/
        void InsertarProductoDetalle(ProductoDetalle productoDetalle);
        List<ProductoDetalle> MostrarproductoDetalle();
        ProductoDetalle buscarproductoDetalle(string codigo);
        void EditarproductoDetalle(ProductoDetalle productoDetalle);
    }
}
