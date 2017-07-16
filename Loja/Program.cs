using Loja.DAO;
using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja
{
    class Program
    {
        static void Main(string[] args)
        {
            //NHibernateHelper.GeraSchema(); // Create table ::>> Drop the table if it exists

            ISession session = NHibernateHelper.AbreSession();
            UsuarioDAO usuarioDAO = new UsuarioDAO(session);

            Usuario usuario = new Usuario();
            usuario.Nome = "Rafael";

            usuarioDAO.Adiciona(usuario);

            session.Close();

            Console.Read();
        }
    }
}
