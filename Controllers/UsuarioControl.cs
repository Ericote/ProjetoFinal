using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;

namespace Controllers
{
    public class UsuarioControl
    {
         public static IEnumerable<Usuario> SelectUsuarios()
        {
            return Models.Usuario.GetUsuarios();  
        }

        public static Usuario DeleteUsuarios(int Id)
        {
            Usuario usuarios = Models.Usuario.GetUsuario(Id);
            Usuario.RemoverUsuario(usuarios);
            return usuarios;
        }

        public static Usuario InserirUsuarios(string Nome, string Email, string Senha)
        {
            if (String.IsNullOrEmpty(Nome))
            {
                throw new Exception("Nome inválido");
            }
            return new Usuario(Nome, Email, Senha);
        }

        public static void UpdateUsuarios(int Id,string Nome,string Email, string Senha)
        {
            Usuario usuario = Models.Usuario.GetUsuario(Id);
            if (!String.IsNullOrEmpty(Nome))
            {
                usuario.Nome = Nome;
            }
            if (!String.IsNullOrEmpty(Email))
            {
                usuario.Email = Email;
            }
            if (!String.IsNullOrEmpty(Senha))
            {
                usuario.Senha = Senha;
            }
            Usuario.AlterarUsuario(Id,Nome,Email,Senha);
        }
    }
}