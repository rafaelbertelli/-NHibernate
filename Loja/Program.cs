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
            // 1
            //NHibernateHelper.GeraSchema(); // Create table ::>> Drop the table if it exists

            // 2
            //ISession session = NHibernateHelper.AbreSession();
            //UsuarioDAO usuarioDAO = new UsuarioDAO(session);
            //Usuario usuario = new Usuario();
            //usuario.Nome = "Rafael";
            //usuarioDAO.Adiciona(usuario);
            //session.Close();

            // 3
            //Categoria outraCategoria = new Categoria();
            //outraCategoria.Nome = "Outra Categoria";
            //Produto produto = new Produto();
            //produto.Nome = "Shorts";
            //produto.Preco = 59.9;
            //produto.Categoria = outraCategoria;
            //ISession session = NHibernateHelper.AbreSession();
            //ITransaction transaction = session.BeginTransaction();
            //session.Save(outraCategoria);
            //session.Save(produto);
            //transaction.Commit();
            //session.Close();

            // 4
            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            Categoria categoria = session.Load<Categoria>(1);
            //IList<Produto> produtos = categoria.Produtos;
            Console.WriteLine(categoria.Produtos.Count);

            transacao.Commit();
            session.Close();

            Console.Read();
        }
    }
}
