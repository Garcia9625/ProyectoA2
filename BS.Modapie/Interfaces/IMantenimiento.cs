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


        /*Gestion de Empleado*/

        void InsertarEmpleado(Empleado empleado);

        List<Empleado> MostrarEmpleado();


        /*Gestion de productos al x Mayor*/
        List<ProductosAlxMayor> MostrarProductos();
        ProductosAlxMayor obtenerLote(int id);
    }
}
