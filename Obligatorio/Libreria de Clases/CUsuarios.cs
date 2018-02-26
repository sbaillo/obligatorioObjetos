using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria_de_Clases
{
    public class CUsuarios
    {
        private static CUsuarios instancia;
        public static CUsuarios Instancia
        {
            get
            {
                if(instancia == null)
                {
                    instancia = new CUsuarios();
                }

                return instancia;
            }
        }

        private List<Usuario> usuarios;
        private string unId;
        private string unPassword;
        private string unNombre;
        private string unRol;

        private CUsuarios()
        {
            usuarios = new List<Usuario>();
        }

        //BUSCAR USUARIO
        public  Usuario BuscarUsuario(string unId)
        {
            Usuario retorno = null;

            bool loEncontre = false;
            int pos = 0;
            while (!loEncontre && pos < usuarios.Count)
            {
                if (usuarios[pos].id == unId)
                {
                    retorno = usuarios[pos]; 
                    loEncontre = true; 
                }
                pos++;
            }

            return retorno;
        }

        //ALTA USUARIO
        public bool AltaUsuario(string id, string password, string nombre, string rol)
        {
            bool ok = false;
            if (this.BuscarUsuario(unId) == null)
            {
              
                Usuario unUsuario = new Usuario(unId, unPassword, unNombre, unRol);
               
                usuarios.Add(unUsuario);
                usuarios.Add(unUsuario);

                ok = true;
            }
            return ok;
        }
    }
}
