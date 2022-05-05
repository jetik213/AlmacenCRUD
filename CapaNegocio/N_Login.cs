using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_Login
    {
        D_Login d_Login = new D_Login();
        public bool LoginUser(E_Login login)
        {
            return d_Login.Login(login);
        }
    }
}
