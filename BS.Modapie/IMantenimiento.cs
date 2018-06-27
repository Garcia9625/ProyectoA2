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
        Usuario obtenerUsuarioUser(string username);

        int validarLogin(string username, string contrasena);
    }
}
