using DO.Modapie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace BS.Modapie
{
    public class Mantenimiento : IMantenimiento
    {
        private static Mantenimiento instancia;

        public static Mantenimiento Instancia
        {
            get
            {
                if (instancia == null)
                {
                    return new Mantenimiento();
                }
                return instancia;
            }
            set
            {
                if (instancia == null)
                {
                    instancia = value;
                }
            }
        }

        public Usuario obtenerUsuarioUser(string username)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    Usuario usuario = DAL.Modapie.Mantenimiento.Instancia.obtenerUsuarioUser(username);
                    scope.Complete();
                    return usuario;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return null;

            }
        }

        
        public int validarLogin(string username, string contrasena)
        {
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    int respuesta = DAL.Modapie.Mantenimiento.Instancia.validarLogin(username, contrasena);
                    scope.Complete();
                    return respuesta;
                }
            }
            catch (Exception ee)
            {
                DialogResult d = MessageBox.Show(ee.Message.ToString());
                return 3;

            }
        }
    }
}
