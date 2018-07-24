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
        void InsertarCAlxMayor(ClienteAlxMayor CAXM);
        List<ClienteAlxMayor> MostarCAXM();


        /*Gestion de Empleado*/

        void InsertarEmpleado(Empleado empleado);

        List<Empleado> MostrarEmpleado();
    }
}
