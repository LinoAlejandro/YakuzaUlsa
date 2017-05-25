using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using YakuzaUlsa.Models;

namespace YakuzaUlsa.Controllers
{
    public class UserUtilities
    {
        static YakuzaAppDBEntities db = new YakuzaAppDBEntities();
        public static bool exists(string nickNameUsuario)
        {
            List<Usuario> usuarios = db.Usuario.Where(u => u.nickNameUsuario == nickNameUsuario).ToList();
            return usuarios.Count > 0;
        }

        public static bool comparePasswords(string passwordUsuario, string confirmPassword)
        {
            return passwordUsuario.Equals(confirmPassword);
        }
    }
}