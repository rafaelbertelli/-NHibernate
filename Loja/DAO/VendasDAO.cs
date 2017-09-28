using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
    public class VendasDAO
    {
        private ISession session;
        public VendasDAO(ISession session)
        {
            this.session = session;
        }
        public void Adiciona(Venda venda)
        {
            session.Save(venda);
        }
        public IList<Venda> Lista()
        {
            IQuery query = session.CreateQuery("from Venda");
            return query.List<Venda>();
        }
    }
}
