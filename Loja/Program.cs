using Loja.DAO;
using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Transform;
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
            //ISession session = NHibernateHelper.AbreSession();
            //ITransaction transacao = session.BeginTransaction();

            //Categoria categoria = session.Load<Categoria>(1);
            //IList<Produto> produtos = categoria.Produtos;
            //Console.WriteLine(produtos.Count);

            //transacao.Commit();
            //session.Close();

            //Console.Read();

            //5
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "from Produto p where p.Preco > :minimo and p.Categoria.Nome = :categoria order by p.Nome";
            //IQuery query = session.CreateQuery(hql);
            //query.SetParameter("minimo", 10);
            //query.SetParameter("categoria", "Uma Categoria");

            //IList <Produto> produtos = query.List<Produto>();

            //foreach(Produto produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome);
            //}

            //Console.Read();

            //6
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "SELECT p.Categoria, count(p) from Produto p GROUP BY p.Categoria";
            //IQuery query = session.CreateQuery(hql);
            //IList<Object[]> resultados = query.List<Object[]>();

            //IList<ProdutosPorCategoria> relatorio = new List<ProdutosPorCategoria>();

            //foreach(Object[] resultado in resultados)
            //{
            //    ProdutosPorCategoria p = new ProdutosPorCategoria();
            //    p.Categoria = (Categoria)resultado[0];
            //    p.NumeroDePedido = (long)resultado[1];

            //    relatorio.Add(p);
            //}

            //session.Close();
            //Console.Read();

            //7
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "SELECT p.Categoria as Categoria, count(p) as NumeroDePedido from Produto p GROUP BY p.Categoria";
            //IQuery query = session.CreateQuery(hql);
            //query.SetResultTransformer(Transformers.AliasToBean<ProdutosPorCategoria>());

            //IList<ProdutosPorCategoria> relatorio = query.List<ProdutosPorCategoria>();

            //session.Close();
            //Console.Read();

            //8
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "from Produto p join fetch p.Categoria";
            //IQuery query = session.CreateQuery(hql);
            //IList<Produto> produtos = query.List<Produto>();

            //foreach (Produto produto in produtos)
            //{
            //    Console.WriteLine(produto.Nome + " - " + produto.Categoria.Nome);
            //}

            //session.Close();
            //Console.Read();

            //9
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "select distinct c from Categoria c join fetch c.Produtos";
            //IQuery query = session.CreateQuery(hql);
            //IList<Categoria> categorias = query.List<Categoria>();

            //foreach (Categoria categoria in categorias)
            //{
            //    Console.WriteLine(categoria.Nome + " - " + categoria.Produtos.Count);
            //}

            //session.Close();
            //Console.Read();

            //10
            //ISession session = NHibernateHelper.AbreSession();
            //String hql = "select distinct c from Categoria c join fetch c.Produtos order by c.Nome";
            //IQuery query = session.CreateQuery(hql);
            //query.SetFirstResult(1);
            //query.SetMaxResults(1);
            //IList<Categoria> categorias = query.List<Categoria>();

            //foreach (Categoria categoria in categorias)
            //{
            //    Console.WriteLine(categoria.Nome + " := " + categoria.Produtos.Count);
            //}

            //session.Close();
            //Console.Read();

            //11
            //ISession session = NHibernateHelper.AbreSession();

            //ProdutoDAO dao = new ProdutoDAO(session);
            //IList<Produto> pd = dao.BuscaPorNomePrecoMinimoECategoria("", 0, "");

            //foreach (var produto in pd)
            //{
            //    Console.WriteLine("Nome: " + produto.Nome + " //// Preco Minimo: " + produto.Preco.ToString() + " //// Categoria: " + produto.Categoria.Nome);
            //}

            //session.Close();
            //Console.Read();

            //12
            //ISession session = NHibernateHelper.AbreSession();
            //ISession session2 = NHibernateHelper.AbreSession();

            //Categoria c = session.Get<Categoria>(1);
            //Categoria c2 = session2.Get<Categoria>(1);

            //Console.WriteLine(c.Produtos.Count);
            //Console.WriteLine(c2.Produtos.Count);

            //session.Close();
            //Console.Read();

            //13
            //ISession session = NHibernateHelper.AbreSession();
            //ISession session2 = NHibernateHelper.AbreSession();

            //session.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();
            //session2.CreateQuery("from Usuario").SetCacheable(true).List<Usuario>();


            //session.Close();
            //Console.Read();

            //14
            //ISession session = NHibernateHelper.AbreSession();
            //ITransaction transacao = session.BeginTransaction();

            //Venda venda = new Venda();
            //Usuario cliente = session.Get<Usuario>(1);
            //venda.Cliente = cliente;

            //Produto p1 = session.Get<Produto>(1);
            //Produto p2 = session.Get<Produto>(2);

            //venda.Produtos.Add(p1);
            //venda.Produtos.Add(p2);

            //session.Save(venda);

            //transacao.Commit();
            //session.Close();
            //Console.Read();

            //15
            ISession session = NHibernateHelper.AbreSession();
            ITransaction transacao = session.BeginTransaction();

            PessoaFisica murilo = new PessoaFisica();
            murilo.Nome = "Murilo";
            murilo.CPF = "123.456.789.00";
            session.Save(murilo);

            PessoaJuridica caelum = new PessoaJuridica();
            caelum.Nome = "Caelum";
            caelum.CNPJ = "123.456/0001-09";
            session.Save(caelum);

            transacao.Commit();
            session.Close();

        }
    }

    public class ProdutosPorCategoria
    {
        public Categoria Categoria { get; set; }
        public long NumeroDePedido { get; set; }
    }
}
