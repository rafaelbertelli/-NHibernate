using Loja.Entidades;
using Loja.Infra;
using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    class ProdutoDAO
    {
        private ISession session;

        public ProdutoDAO(ISession session)
        {
            this.session = session;
        }

        public void Adiciona(Produto produto)
        {
            ITransaction transacao = this.session.BeginTransaction();
            this.session.Save(produto);
            transacao.Commit();
        }

        public Produto BuscaPorId(int id)
        {
            return session.Get<Produto>(id);
        }

        public IList<Produto> BuscaPorNomePrecoMinimoECategoria(string nome, double?  precoMinimo, string categoria)
        {
            ICriteria criteria = session.CreateCriteria<Produto>();

            if (!string.IsNullOrEmpty(nome))
            {
                criteria.Add(Restrictions.Eq("Nome", nome));
            }

            if(precoMinimo > 0)
            {
                criteria.Add(Restrictions.Ge("Preco", precoMinimo));
            }

            if(!string.IsNullOrEmpty(categoria))
            {
                ICriteria criteriaCategoria = criteria.CreateCriteria("Categoria");
                criteriaCategoria.Add(Restrictions.Eq("Nome", categoria));
            }
            
            return criteria.List<Produto>();
        }
    }
}
