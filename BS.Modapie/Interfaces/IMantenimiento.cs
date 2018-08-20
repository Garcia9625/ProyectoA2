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


        /*Gestion de cliente al detalle*/

        void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle);

        List<ClienteAlDetalle> MostrarClienteDetalle();
        ClienteAlDetalle buscarCAD(string dni);

        /*Inventario al x mayor*/

        List<InventarioAlxMayor> obtenerListaInventarioAlxMayor();


        /*Venta al por mayor*/

        void InsertarVentaAlxMayor(VentaAlxMayor ventaAlxMayor);
        VentaAlxMayor buscarUltimaVenta();

        /*Descripcion venta al por mayor*/

        void InsertarDescripcionVentaAlxMayor(DescripcionVentaAlxMayor descripcionVentaAlxMayor);
    }
}
