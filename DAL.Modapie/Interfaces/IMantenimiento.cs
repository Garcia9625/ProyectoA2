using DO.Modapie;
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
        List<ClientePorMayor> MostarCAXM();
        void Editar(ClientePorMayor CAXM);
        void Borrar(ClientePorMayor CAXM);

        /*Gestion Empleado*/

        void InsertarEmpleado(Empleado empleado);

        List<Empleado> MostrarEmpleado();

        Empleado buscarEmpleado(string dni);

        void ActualizarEmpleado(Empleado empleado);

        /*Gestion de Productos al x MAYOR*/
        List<ProductosAlxMayor>MostrarProductos();
        ProductosAlxMayor obtenerLote(int id);

        void EliminarProdXMayor(int id);


        /*Gestion del cliente al detalle*/

        void InsertarClienteAlDetalle(ClienteAlDetalle clienteAlDetalle)
    }
}
