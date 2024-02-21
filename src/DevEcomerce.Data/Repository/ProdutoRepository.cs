using DevEcomerce.Business.Interfaces;
using DevEcomerce.Business.Models;
using DevEcomerce.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevEcomerce.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(EcomerceDbContext context) : base(context)
        {
            
        }
        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            //return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).FirstOrDefaultAsync(p => p.Id == id);
            //return await Db.Produtos.Include(f => f.Fornecedor).FirstAsync(c => c.Id == id);
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).FirstAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).OrderBy(p=>p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p=>p.FornecedorId == fornecedorId);
        }
    }
}
